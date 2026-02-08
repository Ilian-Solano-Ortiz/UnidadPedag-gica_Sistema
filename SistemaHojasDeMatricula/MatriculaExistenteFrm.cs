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

                nivelCbx.Items.Clear();
                nivelCbx.Items.AddRange(new object[]
                {
            "Materno",
            "Kinder"
                });
            }
            else
            {
                primariaCheck.Enabled = true;
                secundariaCheck.Enabled = true;
                nivelCbx.Items.Clear();
            }
        }

        private void primariaCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (primariaCheck.Checked)
            {
                preescolarCheck.Enabled = false;
                secundariaCheck.Enabled = false;

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
                preescolarCheck.Enabled = true;
                secundariaCheck.Enabled = true;
                nivelCbx.Items.Clear();
            }
        }

        private void secundariaCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (secundariaCheck.Checked)
            {
                preescolarCheck.Enabled = false;
                primariaCheck.Enabled = false;

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
                preescolarCheck.Enabled = true;
                primariaCheck.Enabled = true;
                nivelCbx.Items.Clear();
            }
        }


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

        }
    }
}
