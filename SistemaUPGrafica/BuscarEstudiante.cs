using GenerarPDFUP.Models;
using GenerarPDFUP.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SistemaUPGrafica
{
    public partial class BuscarEstudiante : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public Form FormularioActivo { get; set; }

        public Usuario Usuario { get; set; }

        public BuscarEstudiante(IServiceProvider serviceProvider, Usuario usuario)
        {
            InitializeComponent();
            this._serviceProvider = serviceProvider;
            this.Usuario = usuario;
        }

        private void cerrarSesionBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void usuariosBtn_Click(object sender, EventArgs e)
        {
            
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


        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cedulaEstudianteTxt.Text))
            {
                MessageBox.Show("Debe ingresar la cédula del estudiante.".ToUpper(),
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Estudiante estudiante = traerEstudiante(cedulaEstudianteTxt.Text.Trim());

            if (estudiante != null)
            {
                List<Encargado> encargados = traerEncargado(cedulaEstudianteTxt.Text.Trim());
                abrirFormulario(new MatriculaExistenteFrm(estudiante, encargados, this._serviceProvider));
            }
            else
            {
                DialogResult resultado = MessageBox.Show(
                    "El estudiante no existe en la base de datos.\n¿Desea intentarlo nuevamente?",
                    "Estudiante no encontrado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                    abrirFormulario(new FrmMatriculaNoExistente(this._serviceProvider, this.Usuario));
            }
        }


        //Traera la información de los estudiantes de nuestra base de datos
        private Estudiante traerEstudiante(String cedulaEstudiante)
        {
            var estudianteService = _serviceProvider.GetService<EstudianteService>();
            if (estudianteService == null)
            {
                MessageBox.Show("Ocurrió un error inesperado con la base de datos".ToUpper(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return estudianteService.obtenerEstudiante(cedulaEstudiante);

        }
        //Traera la información de los encargados de nuestra base de datos
        private List<Encargado> traerEncargado(String cedulaEstudiante)
        {
            var estudianteService = _serviceProvider.GetService<EstudianteService>();
            if (estudianteService == null)
            {
                MessageBox.Show("Ocurrió un error inesperado con la base de datos".ToUpper(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return estudianteService.obtenerEncargadosEstudiante(cedulaEstudiante);
        }

        //Boton agregado
        private void btnNuevoEstudiante_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmMatriculaNoExistente(this._serviceProvider, this.Usuario));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
