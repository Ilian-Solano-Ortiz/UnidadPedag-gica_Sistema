using GenerarPDFUP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using GenerarPDFUP.Services;
using OfficeOpenXml;

namespace SistemaUPGrafica
{
    public partial class FrmContenedor : Form
    {
        public Form FormularioActivo { get; set; }
        public Usuario Usuario { get; set; }

        private readonly IServiceProvider _serviceProvider;
        private bool _cerrandoSesion = false;

        public FrmContenedor(Usuario usuario, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this._serviceProvider = serviceProvider;
            usuariosBtn.Visible = false;
            FormularioActivo = null;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = true;   // Quita botón maximizar
            this.MinimizeBox = true;   // Quita botón minimizar
            this.FormClosing += (s, e) =>
            {

                if (!_cerrandoSesion)
                {
                    var usuarioServicio = _serviceProvider.GetService<UsuarioService>();
                    usuarioServicio.LogoutUsuario(this.Usuario.CedulaUsuario);
                    //usuarioServicio.ActualizarPropiedadUsuario(this.Usuario.IdUsuario,"Estado","Disponible"); 
                    Application.Exit();
                }
            };
            this.Usuario = usuario;

            if (this.Usuario.RolUsuario.Equals("Administrador"))
            {
                usuariosBtn.Visible = true;
            }
        }

        //CAMBIO DE CÓDIGO PARA QUE LIMPIE CAMPO DE USUARIO Y CONTRASEÑA AL CERRAR SESIÓN
        private void cerrarSesionBtn_Click(object sender, EventArgs e)
        {
            _cerrandoSesion = true;
            Login login = Application.OpenForms["Login"] as Login;

            if (login != null)
            {
                login.LimpiarCampos();
                login.Show();
            }
            var usuarioServicio = _serviceProvider.GetService<UsuarioService>();
            usuarioServicio.LogoutUsuario(this.Usuario.CedulaUsuario);

            this.Close();
        }
        private void abrirFormulario(Form formulario)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            formulario.FormBorderStyle = FormBorderStyle.None;
            FormularioActivo = formulario;
            contenedor.Controls.Add(formulario);

            formulario.Show();
            formulario.BringToFront();

        }
        private void estudiantesBtn_Click(object sender, EventArgs e)
        {
            abrirFormulario(new BuscarEstudiante(this._serviceProvider));
        }

        private void usuariosBtn_Click(object sender, EventArgs e)
        {
            abrirFormulario(new BuscarUsuarios(this.Usuario, this._serviceProvider));
        }

        private void cambiarContraBtn_Click(object sender, EventArgs e)
        {
            abrirFormulario(new CambioContra(this.Usuario, this._serviceProvider));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var estudianteService = _serviceProvider.GetService<EstudianteService>();
            if (estudianteService == null)
            {
                MessageBox.Show("Ocurrió un error inesperado con la base de datos".ToUpper(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccionar archivo Excel de estudiantes";
                openFileDialog.Filter = "Archivos Excel (*.xlsx;*.xls)|*.xlsx;*.xls|Todos los archivos (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                ProcesarExcelEstudiantes(openFileDialog.FileName, estudianteService);
            }
        }
        private void ProcesarExcelEstudiantes(string rutaArchivo, EstudianteService estudianteService)
        {
            ExcelPackage.License.SetNonCommercialOrganization("Univerdiad de Costa Rica");

            int totalInsertados = 0;
            int totalErrores = 0;
            var errores = new System.Text.StringBuilder();

            try
            {
                using (var package = new ExcelPackage(new FileInfo(rutaArchivo)))
                {
                    if (package.Workbook.Worksheets.Count == 0)
                    {
                        MessageBox.Show("El archivo Excel no contiene hojas.".ToUpper(),
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    foreach (ExcelWorksheet hoja in package.Workbook.Worksheets)
                    {
                        if (hoja.Dimension == null || hoja.Dimension.Rows <= 1)
                            continue;

                        ProcesarHoja(hoja, estudianteService, ref totalInsertados, ref totalErrores, errores);
                    }
                }

                MostrarResumen(totalInsertados, totalErrores, errores);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el archivo Excel:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ProcesarHoja(
            ExcelWorksheet hoja,
            EstudianteService estudianteService,
            ref int totalInsertados,
            ref int totalErrores,
            System.Text.StringBuilder errores)
        {
            int totalFilas = hoja.Dimension.Rows;

            for (int fila = 2; fila <= totalFilas; fila++)
            {
                // ── Mapeo de columnas ──────────────────────────────────
                // Col 1: NUMERO DE IDENTIFICACION  → cédula estudiante
                // Col 2: PRIMER APELLIDO
                // Col 3: SEGUNDO APELLIDO
                // Col 4: NOMBRE
                // Col 6: TELEFONO                  → teléfono encargado
                // Col 7: CEDULA ENCARGADO LEGAL    → cédula del encargado
                // Col 8: NOMBRE ENCARGADO LEGAL    → nombre del encargado
                // Col 9: DOMICILIO                 → dirección estudiante
                // ──────────────────────────────────────────────────────

                string cedulaEstudiante = ObtenerCelda(hoja, fila, 1);
                string primerApellido = ObtenerCelda(hoja, fila, 2);
                string segundoApellido = ObtenerCelda(hoja, fila, 3);
                string nombre = ObtenerCelda(hoja, fila, 4);
                string telefonoEncargado = ObtenerCelda(hoja, fila, 6);
                string cedulaEncargado = ObtenerCelda(hoja, fila, 7);
                string nombreEncargado = ObtenerCelda(hoja, fila, 8);
                string domicilio = ObtenerCelda(hoja, fila, 9);

                if (string.IsNullOrWhiteSpace(cedulaEstudiante) && string.IsNullOrWhiteSpace(nombre))
                    continue;

                string nombreCompleto = $"{nombre.Trim()} {primerApellido.Trim()} {segundoApellido.Trim()}".Trim();

                var resultado = estudianteService.registrarEstudianteExcel(
                    cedulaEstudiante,
                    nombreCompleto,
                    cedulaEncargado,
                    nombreEncargado,
                    telefonoEncargado,
                    domicilio
                );

                EvaluarResultado(resultado, hoja.Name, fila, nombreCompleto,
                    ref totalInsertados, ref totalErrores, errores);
            }
        }
        private void EvaluarResultado(
            ResultadoDto resultado,
            string nombreHoja,
            int fila,
            string nombreCompleto,
            ref int totalInsertados,
            ref int totalErrores,
            System.Text.StringBuilder errores)
        {
            switch (resultado?.Resultado)
            {
                case 1:
                    totalInsertados++;
                    break;
                case 2:
                    totalErrores++;
                    errores.AppendLine($"Hoja '{nombreHoja}', Fila {fila}: '{nombreCompleto}' - El estudiante ya existe.");
                    break;
                case 3:
                    totalErrores++;
                    errores.AppendLine($"Hoja '{nombreHoja}', Fila {fila}: '{nombreCompleto}' - Error en base de datos.");
                    break;
                default:
                    totalErrores++;
                    errores.AppendLine($"Hoja '{nombreHoja}', Fila {fila}: '{nombreCompleto}' - Resultado desconocido ({resultado?.Resultado}).");
                    break;
            }
        }
        private void MostrarResumen(int totalInsertados, int totalErrores, System.Text.StringBuilder errores)
        {
            string resumen = $"PROCESO COMPLETADO\n\n" +
                             $"✔  Insertados correctamente: {totalInsertados}\n" +
                             $"✖  Con errores: {totalErrores}";

            if (errores.Length > 0)
            {
                resumen += $"\n\nDetalle de errores:\n{errores}";
                MessageBox.Show(resumen, "Resultado de Carga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(resumen, "Resultado de Carga", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private string ObtenerCelda(ExcelWorksheet hoja, int fila, int columna)
        {
            return hoja.Cells[fila, columna].Value?.ToString()?.Trim() ?? string.Empty;
        }
    }
}
