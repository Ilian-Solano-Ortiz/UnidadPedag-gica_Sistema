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
    public partial class BuscarUsuarios : Form
    {
        public BuscarUsuarios()
        {
            InitializeComponent();
           
        }

        private void cerrarSesionBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void estudiantesBtn_Click(object sender, EventArgs e)
        {
            abrirFormulario(new BuscarEstudiante());
        }

        private void abrirFormulario(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.BringToFront();
            this.Close();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
