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
    public partial class FrmContenedor : Form
    {
        public Form FormularioActivo { get; set; }
        public FrmContenedor()
        {
            InitializeComponent();
            FormularioActivo = null;
        }

        private void cerrarSesionBtn_Click(object sender, EventArgs e)//hice cambios aqui
        {
            abrirFormulario(new Login());

        }
        public void abrirFormulario(Form formulario)

        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            formulario.FormBorderStyle = FormBorderStyle.None;
            FormularioActivo = formulario;
            contenedor.Controls.Add(formulario);

            formulario.Show();
            formulario.BringToFront();

        }
    /*  public void abrirFormulario(Form formulario) //CODIGO QUE ME DIÓ CHAT PORQUE DISQUE HAY QUE CAMBIAR EL DE ARRIBA PERO IGUAL NO ME FUNCIONÓ FOK
        {
            contenedor.Controls.Clear();

            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            formulario.FormBorderStyle = FormBorderStyle.None;

            FormularioActivo = formulario;
            contenedor.Controls.Add(formulario);

            formulario.Show();
            formulario.BringToFront();
        }*/


        private void estudiantesBtn_Click(object sender, EventArgs e)
        {
            abrirFormulario(new BuscarEstudiante());
        }

        private void usuariosBtn_Click(object sender, EventArgs e)
        {
            abrirFormulario(new BuscarUsuarios());
        }

        private void cambiarContraBtn_Click(object sender, EventArgs e)
        {
            abrirFormulario(new CambioContra());
        }
    }
}
