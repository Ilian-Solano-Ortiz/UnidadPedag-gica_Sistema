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
    public partial class FrmContenedor : Form
    {
        public Form FormularioActivo { get; set; }
        public FrmContenedor()
        {
            InitializeComponent();
            FormularioActivo = null;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;   // Quita botón maximizar
            this.MinimizeBox = false;   // Quita botón minimizar
        }

        //CAMBIO DE CÓDIGO PARA QUE LIMPIE CAMPO DE USUARIO Y CONTRASEÑA AL CERRAR SESIÓN
        private void cerrarSesionBtn_Click(object sender, EventArgs e) 
        {
            //this.Close();
            Login login = Application.OpenForms["Login"] as Login;

            if (login != null)
            {
                login.LimpiarCampos();
                login.Show();
            }

            this.Close();
        }
        private void abrirFormulario(Form formulario)
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
