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
    public partial class MatriculaExistenteFrm : Form
    {
     
        public MatriculaExistenteFrm()
        {
            InitializeComponent();
 
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
                siCheck.Enabled = false;
                noCheck.Enabled = false;
                MessageBox.Show("Está seleccionado");
            }
            else
            {
                nivelCbx.Items.Clear();
                primariaCheck.Enabled = true;
                secundariaCheck.Enabled = true;
                inglesCheck.Enabled = true;
                francesCheck.Enabled = true;
                siCheck.Enabled = true;
                noCheck.Enabled = true;
                MessageBox.Show("No seleccionado");
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
                siCheck.Enabled = false;
                noCheck.Enabled = false;
                MessageBox.Show("Está seleccionado");
            }
            else
            {
                nivelCbx.Items.Clear();
                preescolarCheck.Enabled = true;
                secundariaCheck.Enabled = true;
                inglesCheck.Enabled = true;
                francesCheck.Enabled = true;
                siCheck.Enabled = true;
                noCheck.Enabled = true;
                MessageBox.Show("No seleccionado");
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
                MessageBox.Show("Está seleccionado ");
            }
            else
            {
                nivelCbx.Items.Clear();
                preescolarCheck.Enabled = true;
                primariaCheck.Enabled = true;
                MessageBox.Show("No seleccionado");
            }
        }

        private void inglesCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkIngles = (CheckBox)sender;
            String estado = checkIngles.CheckState + "";
            if (estado.Equals("Checked"))
            {
                francesCheck.Enabled = false;
                MessageBox.Show("Está seleccionado ");
            }
            else
            {
                francesCheck.Enabled = true;
                MessageBox.Show("No seleccionado ");
            }
        }

        private void francesCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkFrances = (CheckBox)sender;
            String estado = checkFrances.CheckState + "";
            if (estado.Equals("Checked"))
            {
                inglesCheck.Enabled = false;
                MessageBox.Show("Está seleccionado ");
            }
            else
            {
                inglesCheck.Enabled = true;
                MessageBox.Show("No seleccionado ");
            }
        }

        private void siCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkSi = (CheckBox)sender;
            String estado = checkSi.CheckState + "";
            if (estado.Equals("Checked"))
            {
                noCheck.Enabled = false;
                MessageBox.Show("Está seleccionado ");
            }
            else
            {
                noCheck.Enabled = true;
                MessageBox.Show("No seleccionado ");
            }
        }

        private void noCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkNo = (CheckBox)sender;
            String estado = checkNo.CheckState + "";
            if (estado.Equals("Checked"))
            {
                siCheck.Enabled = false;
                MessageBox.Show("Está seleccionado ");
            }
            else
            {
                siCheck.Enabled = true;
                MessageBox.Show("No seleccionado ");
            }
        }

        private void generarBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola mundo "+fechaMatricula.Text);
        }
    }
}
