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
    public partial class FrmCondicionSocieconomica : Form
    {
        public FrmCondicionSocieconomica()
        {
            InitializeComponent();
        }

        private void checkComedor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmCondicionSocieconomica_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkUniversidad_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmContenedor principal = (FrmContenedor)Application.OpenForms["FrmContenedor"];

            principal.abrirFormulario(new DatosPadres());
        }
    }
}
