using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHojasDeMatricula
{
    public partial class FrmMatriculaNoExistente : Form
    {
        public FrmMatriculaNoExistente()
        {
            InitializeComponent();
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
            }
            else
            {
                checkPrimaria.Enabled = true;
                checkSecundaria.Enabled = true;
                nivelCbx.Items.Clear();
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
            }
            else
            {
                checkPreescolar.Enabled = true;
                checkSecundaria.Enabled = true;
                nivelCbx.Items.Clear();
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
            }
            else
            {
                checkPreescolar.Enabled = true;
                checkPrimaria.Enabled = true;
                nivelCbx.Items.Clear();
            }
        }

        private void fechaNac_Click(object sender, EventArgs e)
        {

        }
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            BuscarEstudiante formPrincipal = (BuscarEstudiante)this.ParentForm;
            formPrincipal.abrirFormulario(new DatosPadres());
            

            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
