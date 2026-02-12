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
using GenerarPDFUP.Services;

namespace SistemaUPGrafica
{
    public partial class FrmCondicionSocieconomica : Form
    {
        public Estudiante? Estudiante { get; set; }
        public Encargado? Encargado { get; set; }
        public CondicionSocioEconomica? CondicionSocioEconomica { get; set; }



        public FrmCondicionSocieconomica(Estudiante estudiante, Encargado encargado)
        {
            InitializeComponent();
            this.Estudiante = estudiante;
            this.Encargado = encargado;
            this.CondicionSocioEconomica = new CondicionSocioEconomica();
            this.montoTxt.Enabled = false;
            habilitacionTiposBecas(false);
            
        }

        private void checkComedor_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            String estado = check.CheckState + "";
            if (estado.Equals("Checked"))
            {
                checkTransporte.Enabled = false;
                checkImas.Enabled = false;
                this.CondicionSocioEconomica.TipoBeca = "Comedor";

            }
            else
            {
                checkTransporte.Enabled = true;
                checkImas.Enabled = true;
                this.CondicionSocioEconomica.TipoBeca = "";
            }
        }

        private void FrmCondicionSocieconomica_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkUniversidad_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            String estado = check.CheckState + "";
            if (estado.Equals("Checked"))
            {
                checkPrimariaInc.Enabled = false;
                checkPrimariaCom.Enabled = false;
                checkSecundariaCom.Enabled = false;
                checkSecundariaInc.Enabled = false;


                this.CondicionSocioEconomica.EducacionEncargado="Universitaria";
            }
            else
            {
                checkPrimariaInc.Enabled = true;
                checkPrimariaCom.Enabled = true;
                checkSecundariaCom.Enabled = true;
                checkSecundariaInc.Enabled = true;
                this.CondicionSocioEconomica.EducacionEncargado="";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                CondicionSocioEconomica.Monto = montoTxt.Text;
                PlantillaNoExistente plantilla = new PlantillaNoExistente();
                SaveFileDialog rutaGuardar = new SaveFileDialog();
                rutaGuardar.Title = "Guardar Archivo";
                rutaGuardar.Filter = "Archivos PDF (*.pdf)|*.pdf";
                rutaGuardar.FileName = "Hoja de matrícula " + Estudiante.NombreEstudiante + ".pdf";
                rutaGuardar.DefaultExt = "pdf";
                if (rutaGuardar.ShowDialog() == DialogResult.OK)
                {
                    string rutaSeleccionada = rutaGuardar.FileName;
                    plantilla.CrearFormulario(rutaSeleccionada, Estudiante, Encargado, CondicionSocioEconomica);
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

        private void checkSiPatronato_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkSi = (CheckBox)sender;
            String estado = checkSi.CheckState + "";
            if (estado.Equals("Checked"))
            {
                checkNoPatronato.Enabled = false;
                this.CondicionSocioEconomica.PagoPatronato = "true";

                montoTxt.Enabled = true;
            }
            else
            {
                montoTxt.Text = "";
                checkNoPatronato.Enabled = true;
                this.CondicionSocioEconomica.PagoPatronato = "";
                montoTxt.Enabled = false;
            }
        }

        private void checkNoPatronato_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkNo = (CheckBox)sender;
            String estado = checkNo.CheckState + "";
            if (estado.Equals("Checked"))
            {
                checkSiPatronato.Enabled = false;
                this.CondicionSocioEconomica.PagoPatronato = "false";
                montoTxt.Text = "";
            }
            else
            {
                checkSiPatronato.Enabled = true;
                this.CondicionSocioEconomica.PagoPatronato = "";
            }
        }

        private void checkSi_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkSi = (CheckBox)sender;
            String estado = checkSi.CheckState + "";
            if (estado.Equals("Checked"))
            {
                habilitacionTiposBecas(true);
                checkNo.Enabled = false;
                this.CondicionSocioEconomica.TieneBeca = "true";

            }
            else
            {
                valorCheckBecas(false);
                habilitacionTiposBecas(false);
                checkNo.Enabled = true;
                this.CondicionSocioEconomica.TieneBeca = "";

            }
        }

        private void checkNo_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkNo = (CheckBox)sender;
            String estado = checkNo.CheckState + "";
            if (estado.Equals("Checked"))
            {
                valorCheckBecas(false);
                habilitacionTiposBecas(false);

                checkSi.Enabled = false;
                this.CondicionSocioEconomica.TieneBeca = "false";
            }
            else
            {
                checkSi.Enabled = true;
                this.CondicionSocioEconomica.TieneBeca = "";
            }
        }

        private void checkImas_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            String estado = check.CheckState + "";
            if (estado.Equals("Checked"))
            {
                checkTransporte.Enabled = false;
                checkComedor.Enabled = false;
                this.CondicionSocioEconomica.TipoBeca = "Imas";

            }
            else
            {
                checkTransporte.Enabled = true;
                checkComedor.Enabled = true;
                this.CondicionSocioEconomica.TipoBeca = "";
            }
        }

        private void checkTransporte_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            String estado = check.CheckState + "";
            if (estado.Equals("Checked"))
            {
                checkImas.Enabled = false;
                checkComedor.Enabled = false;
                this.CondicionSocioEconomica.TipoBeca = "Transporte";

            }
            else
            {
                checkImas.Enabled = true;
                checkComedor.Enabled = true;
                this.CondicionSocioEconomica.TipoBeca = "";
            }
        }

        private void checkPadre_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            String estado = check.CheckState + "";
            if (estado.Equals("Checked"))
            {
                checkMadre.Enabled = false;
                checkPadreyMadre.Enabled = false;
                checkOtros.Enabled = false;
                this.CondicionSocioEconomica.NucleoFamiliar = "Padre";

            }
            else
            {
                checkMadre.Enabled = true;
                checkPadreyMadre.Enabled = true;
                checkOtros.Enabled = true;
                this.CondicionSocioEconomica.NucleoFamiliar = "";
            }
        }

        private void checkMadre_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            String estado = check.CheckState + "";
            if (estado.Equals("Checked"))
            {
                checkPadre.Enabled = false;
                checkPadreyMadre.Enabled = false;
                checkOtros.Enabled = false;
                this.CondicionSocioEconomica.NucleoFamiliar = "Madre";

            }
            else
            {
                checkPadre.Enabled = true;
                checkPadreyMadre.Enabled = true;
                checkOtros.Enabled = true;
                this.CondicionSocioEconomica.NucleoFamiliar = "";
            }
        }

        private void checkPadreyMadre_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            String estado = check.CheckState + "";
            if (estado.Equals("Checked"))
            {
                checkMadre.Enabled = false;
                checkPadre.Enabled = false;
                checkOtros.Enabled = false;
                this.CondicionSocioEconomica.NucleoFamiliar = "Padre y Madre";

            }
            else
            {
                checkMadre.Enabled = true;
                checkPadre.Enabled = true;
                checkOtros.Enabled = true;
                this.CondicionSocioEconomica.NucleoFamiliar = "";
            }
        }

        private void checkOtros_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            String estado = check.CheckState + "";
            if (estado.Equals("Checked"))
            {
                checkMadre.Enabled = false;
                checkPadre.Enabled = false;
                checkPadreyMadre.Enabled = false;
                this.CondicionSocioEconomica.NucleoFamiliar = "Otros";

            }
            else
            {
                checkMadre.Enabled = true;
                checkPadre.Enabled = true;
                checkPadreyMadre.Enabled = true;
                this.CondicionSocioEconomica.NucleoFamiliar = "";
            }
        }

        private void habilitacionTiposBecas(bool habilitar)
        {
            checkImas.Enabled = habilitar;
            checkComedor.Enabled = habilitar;
            checkTransporte.Enabled = habilitar;
        }
        private void valorCheckBecas(bool habilitar)
        {
            checkImas.Checked = habilitar;
            checkComedor.Checked = habilitar;
            checkTransporte.Checked = habilitar;
        }

        private void checkPrimariaInc_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            String estado = check.CheckState + "";
            if (estado.Equals("Checked"))
            {
                checkPrimariaCom.Enabled = false;
                checkSecundariaCom.Enabled = false;
                checkSecundariaInc.Enabled = false;
                checkUniversidad.Enabled = false;
                this.CondicionSocioEconomica.EducacionEncargado="Primaria incompleta";

            }
            else
            {
                checkPrimariaCom.Enabled = true;
                checkSecundariaCom.Enabled = true;
                checkSecundariaInc.Enabled = true;
                checkUniversidad.Enabled = true;
                this.CondicionSocioEconomica.EducacionEncargado="";
            }
        }

        private void checkPrimariaCom_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            String estado = check.CheckState + "";
            if (estado.Equals("Checked"))
            {
                checkPrimariaInc.Enabled = false;
                checkSecundariaCom.Enabled = false;
                checkSecundariaInc.Enabled = false;
                checkUniversidad.Enabled = false;
                this.CondicionSocioEconomica.EducacionEncargado="Primaria completa";

            }
            else
            {
                checkPrimariaInc.Enabled = true;
                checkSecundariaCom.Enabled = true;
                checkSecundariaInc.Enabled = true;
                checkUniversidad.Enabled = true;

                this.CondicionSocioEconomica.EducacionEncargado="";
            }
        }

        private void checkSecundariaInc_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            String estado = check.CheckState + "";
            if (estado.Equals("Checked"))
            {
                checkPrimariaInc.Enabled = false;
                checkPrimariaCom.Enabled = false;
                checkSecundariaCom.Enabled = false;
                checkUniversidad.Enabled = false;

       
                this.CondicionSocioEconomica.EducacionEncargado="Secundaria incompleta";
            }
            else
            {
                checkPrimariaInc.Enabled = true;
                checkPrimariaCom.Enabled = true;
                checkSecundariaCom.Enabled = true;
                checkUniversidad.Enabled = true;
                this.CondicionSocioEconomica.EducacionEncargado="";
            }
        }

        private void checkSecundariaCom_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            String estado = check.CheckState + "";
            if (estado.Equals("Checked"))
            {
                checkPrimariaInc.Enabled = false;
                checkPrimariaCom.Enabled = false;
                checkSecundariaInc.Enabled = false;
                checkUniversidad.Enabled = false;
                this.CondicionSocioEconomica.EducacionEncargado="Secundaria completa";
            }
            else
            {
                checkPrimariaInc.Enabled = true;
                checkPrimariaCom.Enabled = true;
                checkSecundariaInc.Enabled = true;
                checkUniversidad.Enabled = true;
                this.CondicionSocioEconomica.EducacionEncargado="";
            }
        }

       

        

    }
}
