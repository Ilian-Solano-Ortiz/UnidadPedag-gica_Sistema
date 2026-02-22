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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;   // Quita botón maximizar
            this.MinimizeBox = false;   // Quita botón minimizar
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void abrirFormulario(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            
            contenedor.Controls.Add(formulario);
            formulario.Show();
            formulario.BringToFront();
        }
        private void ingresarBtn_Click(object sender, EventArgs e)
        {
            //abrirFormulario(new FrmContenedor());
            FrmContenedor principal = new FrmContenedor();
            principal.Show();
            this.Hide();
        }

        //AÑADÍ ESTO, LO QUE HACE ES LIMPIAR LOS CAMPOS DE USUARIO Y CONTRASEÑA CUANDO SE CIERRA SESIÓN
        public void LimpiarCampos() 
        {
            usuarioTxt.Clear();
            contraseñaTxt.Clear();
            usuarioTxt.Focus();
        }

        private void registrarseBtn_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Registrarse());
        }
    }
}
