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

namespace SistemaUPGrafica
{
    public partial class FrmMatriculaNoExistente : Form
    {
        public Form PanelPadres { get; set; }
        public Estudiante? Estudiante { get; set; }
        public FrmMatriculaNoExistente()
        {
            InitializeComponent();
            this.Estudiante = new Estudiante();
            generarPanelPadres();
            habilitacionComponentes(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkPreescolar_CheckedChanged(object sender, EventArgs e)
        {

            if (checkPreescolar.Checked)
            {
                
                checkPrimaria.Enabled = false;
                checkSecundaria.Enabled = false;
                
                nivelCbx.Items.Clear();
                nivelCbx.Items.AddRange(new object[]
                {
                "Materno",
                "Kinder"
                });

                habilitacionComponentes(true);
                habilitacionInformacionSecundaria(false);
                
                
            }
            else
            {
                checkPrimaria.Enabled = true;
                checkSecundaria.Enabled = true;
            
                nivelCbx.Items.Clear();
                habilitacionComponentes(false);
            }
        }

        private void primariaCheckNo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPrimaria.Checked)
            {
                
                checkPreescolar.Enabled = false;
                checkSecundaria.Enabled = false;
              
                nivelCbx.Items.Clear();
                nivelCbx.Items.AddRange(new object[]
                {
            "Primero",
            "Segundo",
            "Tercero",
            "Cuarto",
            "Quinto",
            "Sexto"
                });
                habilitacionComponentes(true);
                habilitacionInformacionSecundaria(false);

            }
            else
            {
                checkPreescolar.Enabled = true;
                checkSecundaria.Enabled = true;
                nivelCbx.Items.Clear();
                habilitacionComponentes(false);
             
            }
        }


        private void checkSecundaria_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSecundaria.Checked)
            {
                
                checkPreescolar.Enabled = false;
                checkPrimaria.Enabled = false;
              
                nivelCbx.Items.Clear();
                nivelCbx.Items.AddRange(new object[]
                {
            "Séptimo",
            "Octavo",
            "Noveno",
            "Décimo",
            "Undécimo"
                });
                habilitacionComponentes(true);
                
            }
            else
            {
                checkPreescolar.Enabled = true;
                checkPrimaria.Enabled = true;
                nivelCbx.Items.Clear();
                habilitacionComponentes(false);
              
            }
        }

        private void fechaNac_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
   
            editarInformacionEstudiante();
            this.PanelPadres.Show();
            this.PanelPadres.BringToFront();
        }



        private void generarPanelPadres()
        {
            this.PanelPadres = new DatosPadres(this.Estudiante);
            this.PanelPadres.TopLevel = false;
            this.PanelPadres.FormBorderStyle = FormBorderStyle.None;
            this.PanelPadres.Dock = DockStyle.Fill;
            this.Controls.Add(this.PanelPadres);
        }

        private void habilitacionComponentes(bool habilitar)
        {
            inglesCheck.Enabled = habilitar;
            francesCheck.Enabled = habilitar;
            nivelCbx.Enabled = habilitar;
            dateMatricula.Enabled = habilitar;
            dateFechNac.Enabled = habilitar;
            txtNombreEst.Enabled = habilitar;
            txtCedula.Enabled = habilitar;
            direccionText.Enabled = habilitar;
            enfermedadText.Enabled = habilitar;
            tratamientoMedText.Enabled = habilitar;
            noCheck.Enabled = habilitar;
            siCheck.Enabled = habilitar;
            siCheck2.Enabled = habilitar;
            noCheck2.Enabled = habilitar;
            btnNext.Enabled = habilitar;
        }

        private void editarInformacionEstudiante()
        {
            this.Estudiante.CedulaEstudiante = txtCedula.Text;
            this.Estudiante.NombreEstudiante = txtNombreEst.Text;
            this.Estudiante.NivelEstudiante = nivelCbx.Text;
            this.Estudiante.FechaMatricula = construirFecha(dateMatricula.Text);
            this.Estudiante.FechaNacimiento = construirFecha(dateFechNac.Text);
            this.Estudiante.Direccion = direccionText.Text;
            this.Estudiante.EnfermedadEstudiante = enfermedadText.Text;
            this.Estudiante.TratamientoEstudiante = tratamientoMedText.Text;
            editarNivelSeleccionado();
            
        }

        private void editarNivelSeleccionado()
        {
            if (checkPreescolar.Checked)
            {
                
                this.Estudiante.NivelSeleccionado = "Preescolar";
            }
            else if (checkPrimaria.Checked)
            {
                
                this.Estudiante.NivelSeleccionado = "Primaria";
            }
            else if (checkSecundaria.Checked)
            {
                
                this.Estudiante.NivelSeleccionado = "Secundaria";
            }
        }

        private void siCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkSi = (CheckBox)sender;
            String estado = checkSi.CheckState + "";
            if (estado.Equals("Checked"))
            {
                noCheck.Enabled = false;
                this.Estudiante.HorasTC = "true";
            }
            else
            {
                noCheck.Enabled = true;
                this.Estudiante.HorasTC = "";
            }
        }

        private void noCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkNo = (CheckBox)sender;
            String estado = checkNo.CheckState + "";
            if (estado.Equals("Checked"))
            {
                siCheck.Enabled = false;
                this.Estudiante.HorasTC = "false";
            }
            else
            {
                siCheck.Enabled = true;
                this.Estudiante.HorasTC = "";
            }
        }

        private void siCheck2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkSi = (CheckBox)sender;
            String estado = checkSi.CheckState + "";
            if (estado.Equals("Checked"))
            {
                noCheck2.Enabled = false;
                this.Estudiante.AdecuacionAprobada = "true";
            }
            else
            {
                noCheck2.Enabled = true;
                this.Estudiante.AdecuacionAprobada = "";
            }
        }

        private void noCheck2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkNo = (CheckBox)sender;
            String estado = checkNo.CheckState + "";
            if (estado.Equals("Checked"))
            {
                siCheck2.Enabled = false;
                this.Estudiante.AdecuacionAprobada = "false";
            }
            else
            {
                siCheck2.Enabled = true;
                this.Estudiante.AdecuacionAprobada = "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void habilitacionInformacionSecundaria(bool habilitar)
        {
            inglesCheck.Checked = habilitar;
            francesCheck.Checked = habilitar;
            siCheck.Checked = habilitar;
            noCheck.Checked = habilitar;
            inglesCheck.Enabled = habilitar;
            francesCheck.Enabled = habilitar;
            siCheck.Enabled = habilitar;
            noCheck.Enabled = habilitar;
        }

        private string construirFecha(string fecha)
        {
            int posicionfecha = fecha.IndexOf(',');
            string fechaFinal = fecha.Substring(posicionfecha + 1);
            return fechaFinal.TrimStart();
        }
    }
}
