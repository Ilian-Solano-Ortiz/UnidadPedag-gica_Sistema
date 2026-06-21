using GenerarPDFUP.Models;
using GenerarPDFUP.Services;
using Microsoft.Extensions.DependencyInjection;

namespace SistemaUPGrafica
{
    public partial class MatriculaExistenteFrm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly Action _volverABuscarEstudiante;
        public Estudiante? Estudiante { get; set; }
        public List<Encargado> Encargados;
        public Usuario? Usuario { get; set; }
        public Encargado? EncargadoSeleccionado { get; set; }
        public List<List<String>> Grados = new List<List<String>>{
            new List<string>{"materno","kinder" },
            new List<string>{"primero","segundo","tercero","cuarto","quinto","sexto"},
            new List<string>{"séptimo","octavo","noveno","décimo","undécimo"}
        };
        public string PagoPatronato { get; set; } = "";

        public MatriculaExistenteFrm(Usuario usuario,Estudiante estudiante,List<Encargado> encargados,IServiceProvider serviceProvider,Action volverABuscarEstudiante)
        {
            InitializeComponent();

            this._serviceProvider = serviceProvider;
            this._volverABuscarEstudiante = volverABuscarEstudiante;

            this.Estudiante = estudiante;
            this.Encargados = encargados;
            this.Usuario = usuario;

            llenarCampos();
            habilitacionComponentes(false);
        }

        private void preescolarCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkPrescolar = (CheckBox)sender;
            String estado = checkPrescolar.CheckState + "";
            if (estado.Equals("Checked"))
            {
                primariaCheck.Enabled = false;
                secundariaCheck.Enabled = false;

                nivelCbx.Items.AddRange(new object[] {
                 "Materno",
                 "Kinder"});
                inglesCheck.Enabled = false;
                francesCheck.Enabled = false;
                siCheckTC.Enabled = false;
                noCheckTC.Enabled = false;
                habilitacionComponentes(true);
                habilitacionInformacionSecundaria(false);
            }
            else
            {
                nivelCbx.Items.Clear();
                primariaCheck.Enabled = true;
                secundariaCheck.Enabled = true;
                inglesCheck.Enabled = true;
                francesCheck.Enabled = true;
                siCheckTC.Enabled = true;
                noCheckTC.Enabled = true;
                habilitacionComponentes(false);
                habilitacionInformacionSecundaria(false);
            }
        }

        private void primariaCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkPrimaria = (CheckBox)sender;
            String estado = checkPrimaria.CheckState + "";
            if (estado.Equals("Checked"))
            {
                preescolarCheck.Enabled = false;
                secundariaCheck.Enabled = false;

                nivelCbx.Items.AddRange(new object[] {
                 "Primero",
                 "Segundo",
                 "Tercero",
                 "Cuarto",
                 "Quinto",
                 "Sexto"});
                inglesCheck.Enabled = false;
                francesCheck.Enabled = false;
                siCheckTC.Enabled = false;
                noCheckTC.Enabled = false;
                habilitacionComponentes(true);
                habilitacionInformacionSecundaria(false);
            }
            else
            {
                nivelCbx.Items.Clear();
                preescolarCheck.Enabled = true;
                secundariaCheck.Enabled = true;
                inglesCheck.Enabled = true;
                francesCheck.Enabled = true;
                siCheckTC.Enabled = true;
                noCheckTC.Enabled = true;
                habilitacionComponentes(false);
                habilitacionInformacionSecundaria(false);
            }
        }

        private void secundariaCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkSecundaria = (CheckBox)sender;
            String estado = checkSecundaria.CheckState + "";
            if (estado.Equals("Checked"))
            {
                preescolarCheck.Enabled = false;
                primariaCheck.Enabled = false;

                nivelCbx.Items.AddRange(new object[] {
                 "Séptimo",
                 "Octavo",
                 "Noveno",
                 "Décimo",
                 "Undécimo"});
                habilitacionComponentes(true);
                habilitacionInformacionSecundaria(true);

            }
            else
            {
                nivelCbx.Items.Clear();
                preescolarCheck.Enabled = true;
                primariaCheck.Enabled = true;
                habilitacionComponentes(false);
                quitarChecks(false);
                habilitacionInformacionSecundaria(false);

            }
        }

        private void inglesCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkIngles = (CheckBox)sender;
            String estado = checkIngles.CheckState + "";
            if (estado.Equals("Checked"))
            {
                francesCheck.Enabled = false;
                this.Estudiante.IdiomaElegido = "Inglés";
            }
            else
            {
                francesCheck.Enabled = true;
                this.Estudiante.IdiomaElegido = "";
            }
        }

        private void francesCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkFrances = (CheckBox)sender;
            String estado = checkFrances.CheckState + "";
            if (estado.Equals("Checked"))
            {
                inglesCheck.Enabled = false;
                this.Estudiante.IdiomaElegido = "Francés";
            }
            else
            {
                inglesCheck.Enabled = true;
                this.Estudiante.IdiomaElegido = "";
            }
        }

        private void siCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkSi = (CheckBox)sender;
            String estado = checkSi.CheckState + "";
            if (estado.Equals("Checked"))
            {
                noCheckTC.Enabled = false;
                this.Estudiante.HorasTC = "true";
            }
            else
            {
                noCheckTC.Enabled = true;
                this.Estudiante.HorasTC = "";
            }
        }

        private void noCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkNo = (CheckBox)sender;
            String estado = checkNo.CheckState + "";
            if (estado.Equals("Checked"))
            {
                siCheckTC.Enabled = false;
                this.Estudiante.HorasTC = "false";
            }
            else
            {
                siCheckTC.Enabled = true;
                this.Estudiante.HorasTC = "";
            }
        }

        private void generarBtn_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un nivel (checkbox)
            if (!preescolarCheck.Checked && !primariaCheck.Checked && !secundariaCheck.Checked)
            {
                MessageBox.Show("Debe seleccionar un nivel (Preescolar, Primaria o Secundaria).".ToUpper(),
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que se haya seleccionado un grado en el combobox
            if (nivelCbx.SelectedIndex == -1 || string.IsNullOrWhiteSpace(nivelCbx.Text))
            {
                MessageBox.Show("Debe seleccionar un grado en el nivel.".ToUpper(),
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(annoLectivoTxt.Text))
            {
                MessageBox.Show("Debe ingresar el año lectivo.".ToUpper(),
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cedulaEncargadoTxt.Text) ||
                string.IsNullOrWhiteSpace(nombreEncargadoTxt.Text))
            {
                MessageBox.Show("Debe completar los datos del encargado.".ToUpper(),
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(telefonoEncargadoTxt.Text))
            {
                MessageBox.Show("El campo de teléfono del encargado es obligatorio.".ToUpper(),
                    "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarTelefono(telefonoEncargadoTxt.Text.Trim()))
            {
                MessageBox.Show("El teléfono debe tener el formato: 6230-1020", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(correoEncargadoTxt.Text))
            {
                MessageBox.Show("El campo de correo electrónico del encargado es obligatorio.".ToUpper(),
                    "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCorreo(correoEncargadoTxt.Text.Trim()))
            {
                MessageBox.Show("El correo debe tener un formato válido. Ejemplo: ejemplo@gmail.com", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var estudianteService = _serviceProvider.GetService<EstudianteService>();
            if (estudianteService == null)
            {
                MessageBox.Show("Ocurrió un error inesperado con la base de datos".ToUpper(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                editarInformacionEstudiante();

               
                int idEncargado = this.EncargadoSeleccionado?.IdEncargado ?? 0;

                var resultado = estudianteService.MatriculaEstudianteExistente(
                    idUsuario: this.Usuario?.IdUsuario ?? 0,
                    idEstudiante: this.Estudiante.IdEstudiante,
                    CedulaEstudiante: cedulaEstudianteTxt.Text,
                    NombreEstudiante: nombreCompletoTxt.Text,
                    idEncargado: idEncargado,
                    cedulaEncargado: cedulaEncargadoTxt.Text,
                    nombreEncargado: nombreEncargadoTxt.Text,
                    telefonoEncargado: telefonoEncargadoTxt.Text,
                    correo: correoEncargadoTxt.Text,
                    fechaMatricula: construirFecha(fechaMatricula.Text),
                    annoLectivo: annoLectivoTxt.Text,
                    nivelSeleccionado: this.Estudiante.NivelSeleccionado,
                    idiomaElegido: this.Estudiante.IdiomaElegido ?? string.Empty
                );

                switch (resultado?.Resultado)
                {
                    case 1:
                        GenerarPDF(resultado.IdMatricula ?? 0);
                        break;
                    case 2:
                        MessageBox.Show(
                            "Este estudiante ya tiene una matrícula registrada para este año lectivo.".ToUpper(),
                            "Matrícula duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 4:
                        MessageBox.Show(
                            "El estudiante no es válido.".ToUpper(),
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show("Error" + resultado?.Resultado,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema al generar la hoja de matrícula.".ToUpper(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString());
            }
        }

       
        private void GenerarPDF(long idMatricula)
        {
            SaveFileDialog rutaGuardar = new SaveFileDialog
            {
                Title = "Guardar Archivo",
                Filter = "Archivos PDF (*.pdf)|*.pdf",
                FileName = "Hoja de matrícula " + Estudiante.NombreEstudiante + ".pdf",
                DefaultExt = "pdf"
            };

            if (rutaGuardar.ShowDialog() != DialogResult.OK)
            {
            
                EliminarMatriculaSiCancela(idMatricula);
                MessageBox.Show(
                    "Se ha cancelado la generación. La matrícula no fue registrada.".ToUpper(),
                    "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            try
            {
                Encargado encargadoFinal = new Encargado
                {
                    IdEncargado = this.EncargadoSeleccionado?.IdEncargado ?? 0,
                    CedulaEncargado = cedulaEncargadoTxt.Text,
                    NombreEncargado = nombreEncargadoTxt.Text,
                    TelefonoEncargado = telefonoEncargadoTxt.Text,
                    Correo = correoEncargadoTxt.Text,
                    Parentesco = this.EncargadoSeleccionado?.Parentesco ?? "No especificado",
                    LugarTrabajo = this.EncargadoSeleccionado?.LugarTrabajo ?? "No especificado",
                    NombreContactoEmergencia = this.EncargadoSeleccionado?.NombreContactoEmergencia ?? "No especificado",
                    TelefonoContactoEmergencia = this.EncargadoSeleccionado?.TelefonoContactoEmergencia ?? "00000000"
                };
                PlantillaExistente plantilla = new PlantillaExistente();
                plantilla.CrearFormulario(
                    idMatricula,
                    rutaGuardar.FileName,
                    this.Estudiante,
                    encargadoFinal,
                    PagoPatronato,
                    montoPatronatoTxt.Text,
                    annoLectivoTxt.Text,
                    observacionesTxt.Text);

                MessageBox.Show(
                    "Se ha generado la hoja de matrícula con éxito".ToUpper(),
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _volverABuscarEstudiante?.Invoke();
            }
            catch (Exception ex)
            {
            
                EliminarMatriculaSiCancela(idMatricula);
                MessageBox.Show(
                    "Hubo un problema al generar el PDF. La matrícula no fue registrada.".ToUpper(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString());
            }
        }

      
        private void EliminarMatriculaSiCancela(long idMatricula)
        {
            if (idMatricula <= 0) return;

            var estudianteService = _serviceProvider.GetService<EstudianteService>();
            if (estudianteService == null) return;

            int resultadoEliminar = estudianteService.EliminarMatricula(idMatricula);

            if (resultadoEliminar != 1)
            {
                MessageBox.Show(
                    $"Advertencia: No se pudo eliminar la matrícula con ID {idMatricula}. Contacte al administrador.".ToUpper(),
                    "Error de rollback", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llenarCampos()
        {
            nombreCompletoTxt.Text = this.Estudiante?.NombreEstudiante ?? string.Empty;
            cedulaEstudianteTxt.Text = this.Estudiante?.CedulaEstudiante ?? string.Empty;

            if (this.Encargados != null && this.Encargados.Count > 0)
            {
                this.EncargadoSeleccionado = this.Encargados[0];

                if (this.Encargados.Count == 1)
                {
                    encargadosCb.Visible = false;
                    encargadosLabel.Visible = false;
                    nuevoEncargadoCheck.Visible = true;
                    CargarDatosEncargado(this.Encargados[0]);
                }
                else
                {
                    encargadosCb.Visible = true;
                    encargadosLabel.Visible = true;
                    nuevoEncargadoCheck.Visible = true;

                    encargadosCb.SelectedIndexChanged -= encargadosCb_SelectedIndexChanged;
                    encargadosCb.DisplayMember = "NombreEncargado";
                    encargadosCb.ValueMember = "IdEncargado";
                    encargadosCb.DataSource = this.Encargados;
                    encargadosCb.SelectedIndexChanged += encargadosCb_SelectedIndexChanged;

                    CargarDatosEncargado(this.Encargados[0]);
                }
            }
            else
            {
                encargadosCb.Visible = false;
                encargadosLabel.Visible = false;
                nuevoEncargadoCheck.Visible = false;

                HabilitarCamposEncargado(true);

                MessageBox.Show(
                    "No se encontró encargado asociado a este estudiante.\nPuede completar los datos manualmente.".ToUpper(),
                    "Encargado no encontrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void CargarDatosEncargado(Encargado encargado)
        {
            cedulaEncargadoTxt.Text = encargado.CedulaEncargado ?? string.Empty;
            nombreEncargadoTxt.Text = encargado.NombreEncargado ?? string.Empty;
            telefonoEncargadoTxt.Text = encargado.TelefonoEncargado ?? string.Empty;
            correoEncargadoTxt.Text = encargado.Correo ?? string.Empty;
        }

        private void editarInformacionEstudiante()
        {
            this.Estudiante.CedulaEstudiante = cedulaEstudianteTxt.Text;
            this.Estudiante.NombreEstudiante = nombreCompletoTxt.Text;
            this.Estudiante.NivelEstudiante = nivelCbx.Text;
            this.Estudiante.FechaMatricula = construirFecha(fechaMatricula.Text);
            editarNivelSeleccionado();

        }

        private void editarNivelSeleccionado()
        {
            if (preescolarCheck.Checked)
            {
                this.Estudiante.NivelSeleccionado = "Preescolar";
            }
            else if (primariaCheck.Checked)
            {
                this.Estudiante.NivelSeleccionado = "Primaria";
            }
            else if (secundariaCheck.Checked)
            {
                this.Estudiante.NivelSeleccionado = "Secundaria";
            }
        }

        private void siCheckAdecuacion_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkSi = (CheckBox)sender;
            String estado = checkSi.CheckState + "";
            if (estado.Equals("Checked"))
            {
                noCheckAdecuacion.Enabled = false;
                this.Estudiante.AdecuacionAprobada = "true";
            }
            else
            {
                noCheckAdecuacion.Enabled = true;
                this.Estudiante.AdecuacionAprobada = "";
            }
        }

        private void encargadosCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (encargadosCb.SelectedItem is Encargado encargadoSeleccionado)
            {
                this.EncargadoSeleccionado = encargadoSeleccionado;
                CargarDatosEncargado(encargadoSeleccionado);
                HabilitarCamposEncargado(false); // solo lectura si es existente
            }
        }

        private void noCheckAdecuacion_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkNo = (CheckBox)sender;
            String estado = checkNo.CheckState + "";
            if (estado.Equals("Checked"))
            {
                siCheckAdecuacion.Enabled = false;
                this.Estudiante.AdecuacionAprobada = "false";
            }
            else
            {
                siCheckAdecuacion.Enabled = true;
                this.Estudiante.AdecuacionAprobada = "";
            }
        }

        private void siCheckPatronato_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkSi = (CheckBox)sender;
            String estado = checkSi.CheckState + "";
            if (estado.Equals("Checked"))
            {
                noCheckPatronato.Enabled = false;
                this.PagoPatronato = "true";
                montoPatronatoTxt.Enabled = true;
            }
            else
            {
                noCheckPatronato.Enabled = true;
                this.PagoPatronato = "";
                montoPatronatoTxt.Enabled = false;
            }
        }

        private void noCheckPatronato_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkNo = (CheckBox)sender;
            String estado = checkNo.CheckState + "";
            if (estado.Equals("Checked"))
            {
                siCheckPatronato.Enabled = false;
                this.PagoPatronato = "false";

            }
            else
            {
                siCheckPatronato.Enabled = true;
                this.PagoPatronato = "";

            }
        }

        private void habilitacionInformacionSecundaria(bool habilitar)
        {
            inglesCheck.Enabled = habilitar;
            francesCheck.Enabled = habilitar;
            siCheckTC.Enabled = habilitar;
            noCheckTC.Enabled = habilitar;


        }

        private void quitarChecks(bool habilitar)
        {
            inglesCheck.Checked = habilitar;
            francesCheck.Checked = habilitar;
            siCheckTC.Checked = habilitar;
            noCheckTC.Checked = habilitar;
        }
        private void habilitacionComponentes(bool habilitar)
        {
            nivelCbx.Enabled = habilitar;
            fechaMatricula.Enabled = habilitar;
            annoLectivoTxt.Enabled = habilitar;
            nombreCompletoTxt.Enabled = habilitar;
            cedulaEstudianteTxt.Enabled = habilitar;
            cedulaEncargadoTxt.Enabled = habilitar;
            nombreEncargadoTxt.Enabled = habilitar;
            telefonoEncargadoTxt.Enabled = habilitar;
            inglesCheck.Enabled = habilitar;
            francesCheck.Enabled = habilitar;
            noCheckTC.Enabled = habilitar;
            siCheckTC.Enabled = habilitar;
            siCheckAdecuacion.Enabled = habilitar;
            noCheckAdecuacion.Enabled = habilitar;
            correoEncargadoTxt.Enabled = habilitar;
            siCheckPatronato.Enabled = habilitar;
            noCheckPatronato.Enabled = habilitar;
            observacionesTxt.Enabled = habilitar;
            generarBtn.Enabled = habilitar;
        }

        private string construirFecha(string fecha)
        {
            int posicionfecha = fecha.IndexOf(',');
            string fechaFinal = fecha.Substring(posicionfecha + 1);
            return fechaFinal.TrimStart();
        }

        private void nuevoEncargadoCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (nuevoEncargadoCheck.Checked)
            {
                this.EncargadoSeleccionado = null;
                encargadosCb.Enabled = false;
                HabilitarCamposEncargado(true);
                LimpiarCamposEncargado();
            }
            else
            {
             
                encargadosCb.Enabled = true;
                HabilitarCamposEncargado(false);

                if (this.Encargados != null && this.Encargados.Count > 0)
                {
                    var encargado = encargadosCb.Visible
                        ? (encargadosCb.SelectedItem as Encargado ?? this.Encargados[0])
                        : this.Encargados[0];

                    this.EncargadoSeleccionado = encargado;
                    CargarDatosEncargado(encargado);
                }
            }
        }

        private void HabilitarCamposEncargado(bool habilitar)
        {
            cedulaEncargadoTxt.Enabled = habilitar;
            nombreEncargadoTxt.Enabled = habilitar;
            telefonoEncargadoTxt.Enabled = habilitar;
            correoEncargadoTxt.Enabled = habilitar;
        }

        private void LimpiarCamposEncargado()
        {
            cedulaEncargadoTxt.Text = string.Empty;
            nombreEncargadoTxt.Text = string.Empty;
            telefonoEncargadoTxt.Text = string.Empty;
            correoEncargadoTxt.Text = string.Empty;
        }

        private bool ValidarTelefono(string telefono)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^\d{4}-\d{4}$");
            return regex.IsMatch(telefono);
        }

        private bool ValidarCorreo(string correo)
        {
            return correo.Contains("@") && correo.Contains(".");
        }
    }
}
