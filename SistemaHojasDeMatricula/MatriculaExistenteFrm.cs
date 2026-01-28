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
                MessageBox.Show("Está seleccionado");
            }
            else
            {
                primariaCheck.Enabled = true;
                secundariaCheck.Enabled = true;
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
                MessageBox.Show("Está seleccionado");
            }
            else
            {
                preescolarCheck.Enabled = true;
                secundariaCheck.Enabled = true;
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
                preescolarCheck.Enabled = true;
                primariaCheck.Enabled = true;
                MessageBox.Show("No seleccionado");
            }
        }

        
    }
}
