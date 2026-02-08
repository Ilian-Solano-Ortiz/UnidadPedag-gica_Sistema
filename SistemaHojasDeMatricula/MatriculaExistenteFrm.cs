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
//modifiqué los check
        private void preescolarCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (preescolarCheck.Checked)
            {
                primariaCheck.Enabled = false;
                secundariaCheck.Enabled = false;
<<<<<<< HEAD

                nivelCbx.Items.Clear();
                nivelCbx.Items.AddRange(new object[]
                {
            "Materno",
            "Kinder"
                });
=======
                
                nivelCbx.Items.AddRange(new object[] {
                 "Materno",
                 "Kinder"});
                inglesCheck.Enabled = false;
                francesCheck.Enabled = false;
                siCheck.Enabled = false;
                noCheck.Enabled = false;
                MessageBox.Show("Está seleccionado");
>>>>>>> d69846e49f1b1a070f92197d78d501781ca436c1
            }
            else
            {
                nivelCbx.Items.Clear();
                primariaCheck.Enabled = true;
                secundariaCheck.Enabled = true;
<<<<<<< HEAD
                nivelCbx.Items.Clear();
=======
                inglesCheck.Enabled = true;
                francesCheck.Enabled = true;
                siCheck.Enabled = true;
                noCheck.Enabled = true;
                MessageBox.Show("No seleccionado");
>>>>>>> d69846e49f1b1a070f92197d78d501781ca436c1
            }
        }

        private void primariaCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (primariaCheck.Checked)
            {
                preescolarCheck.Enabled = false;
                secundariaCheck.Enabled = false;
<<<<<<< HEAD

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
=======
                
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
>>>>>>> d69846e49f1b1a070f92197d78d501781ca436c1
            }
            else
            {
                nivelCbx.Items.Clear();
                preescolarCheck.Enabled = true;
                secundariaCheck.Enabled = true;
<<<<<<< HEAD
                nivelCbx.Items.Clear();
=======
                inglesCheck.Enabled = true;
                francesCheck.Enabled = true;
                siCheck.Enabled = true;
                noCheck.Enabled = true;
                MessageBox.Show("No seleccionado");
>>>>>>> d69846e49f1b1a070f92197d78d501781ca436c1
            }
        }

        private void secundariaCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (secundariaCheck.Checked)
            {
                preescolarCheck.Enabled = false;
                primariaCheck.Enabled = false;
<<<<<<< HEAD

                nivelCbx.Items.Clear();
                nivelCbx.Items.AddRange(new object[]
                {
            "Séptimo",
            "Octavo",
            "Noveno",
            "Décimo",
            "Undécimo"
                });
=======
                
                nivelCbx.Items.AddRange(new object[] {
                 "Séptimo",
                 "Octavo",
                 "Noveno",
                 "Décimo",
                 "Undécimo"});
                MessageBox.Show("Está seleccionado ");
>>>>>>> d69846e49f1b1a070f92197d78d501781ca436c1
            }
            else
            {
                nivelCbx.Items.Clear();
                preescolarCheck.Enabled = true;
                primariaCheck.Enabled = true;
                nivelCbx.Items.Clear();
            }
        }

<<<<<<< HEAD

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nivelCbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MatriculaExistenteFrm_Load(object sender, EventArgs e)
        {

=======
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
>>>>>>> d69846e49f1b1a070f92197d78d501781ca436c1
        }
    }
}
