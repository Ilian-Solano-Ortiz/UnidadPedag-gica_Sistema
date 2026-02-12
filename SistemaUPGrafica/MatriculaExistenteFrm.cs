using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenerarPDFUP.Models;
using GenerarPDFUP.Services;

namespace SistemaUPGrafica
{
    public partial class MatriculaExistenteFrm : Form
    {

        public Estudiante? Estudiante { get; set; }
        public Encargado? Encargado { get; set; }
        //Pendiente verificar con los datos de la base de datos para saber si se escribe igual
        public List<List<String>> Grados = new List<List<String>>{
            new List<string>{"materno","kinder" },
            new List<string>{"primero","segundo","tercero","cuarto","quinto","sexto"},
            new List<string>{"séptimo","octavo","noveno","décimo","undécimo"}
        };

        public string PagoPatronato { get; set; } = "";
        public MatriculaExistenteFrm(Estudiante estudiante, Encargado encargado)
        {
            InitializeComponent();
            this.Estudiante = estudiante;
            this.Encargado = encargado;
            llenarCampos();
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
            try
            {
                editarInformacionEstudiante();
                PlantillaExistente plantilla = new PlantillaExistente();
                SaveFileDialog rutaGuardar = new SaveFileDialog();
                rutaGuardar.Title = "Guardar Archivo";
                rutaGuardar.Filter = "Archivos PDF (*.pdf)|*.pdf";
                rutaGuardar.FileName = "Hoja de matrícula " + Estudiante.NombreEstudiante + ".pdf";
                rutaGuardar.DefaultExt = "pdf";
                if (rutaGuardar.ShowDialog() == DialogResult.OK)
                {
                    string rutaSeleccionada = rutaGuardar.FileName;
                    plantilla.CrearFormulario(rutaSeleccionada, Estudiante, Encargado, PagoPatronato, montoPatronatoTxt.Text );
                    MessageBox.Show("Se ha generado la hoja de matrícula con éxito".ToUpper(), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se ha cancelado la hoja de matrícula".ToUpper(), "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema al generar la hoja de matrícula".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void llenarCampos()
        {
            nombreCompletoTxt.Text = Estudiante.NombreEstudiante;
            cedulaTxt.Text = Estudiante.CedulaEstudiante;
            telefonoEncargadoTxt.Text = Encargado.TelefonoEncargado;
            llenarCheckNiveles();
            nivelCbx.SelectedItem = Estudiante.NivelEstudiante;
        }

        private void llenarCheckNiveles()
        {
            for (int i = 0; i < Grados.Count; i++)
            {

                for (int j = 0; j < Grados[i].Count; j++)
                {
                    if (Grados[i][j].ToLower().Equals(Estudiante.NivelEstudiante.ToLower()))
                    {

                        if (i == 0)
                        {

                            preescolarCheck.Checked = true;
                            
                            return;
                        }
                        else if (i == 1)
                        {

                            primariaCheck.Checked = true;
                            
                            return;
                        }
                        else
                        {

                            secundariaCheck.Checked = true;
                            
                            return;
                        }

                    }
                }

            }
        }
        private void editarInformacionEstudiante()
        {
            this.Estudiante.CedulaEstudiante = cedulaTxt.Text;
            this.Estudiante.NombreEstudiante = nombreCompletoTxt.Text;
            this.Estudiante.NivelEstudiante = nivelCbx.Text;
            this.Estudiante.FechaMatricula = construirFecha(fechaMatricula.Text);
            editarNivelSeleccionado();
            this.Encargado.TelefonoEncargado = telefonoEncargadoTxt.Text;


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
            nombreCompletoTxt.Enabled = habilitar;
            cedulaTxt.Enabled = habilitar;
            telefonoEncargadoTxt.Enabled = habilitar;
            inglesCheck.Enabled = habilitar;
            francesCheck.Enabled = habilitar;
            noCheckTC.Enabled = habilitar;
            siCheckTC.Enabled = habilitar;
            siCheckAdecuacion.Enabled = habilitar;
            noCheckAdecuacion.Enabled = habilitar;
            
            siCheckPatronato.Enabled = habilitar;
            noCheckPatronato.Enabled = habilitar;
            generarBtn.Enabled = habilitar;
        }

        private string construirFecha(string fecha)
        {
            int posicionfecha = fecha.IndexOf(',');
            string fechaFinal = fecha.Substring(posicionfecha + 1);
            return fechaFinal.TrimStart();
        }
    }
}
