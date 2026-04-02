using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenerarPDFUP.Data;
using GenerarPDFUP.Models;
using GenerarPDFUP.Services;
using Microsoft.Extensions.DependencyInjection;

namespace SistemaUPGrafica
{
    public partial class Login : Form
    {

        private readonly IServiceProvider _serviceProvider;

        public Login(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this._serviceProvider = serviceProvider;
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
            Loguearse();
        }

        // LO QUE HACE ES LIMPIAR LOS CAMPOS DE USUARIO Y CONTRASEÑA CUANDO SE CIERRA SESIÓN
        public void LimpiarCampos()
        {
            cedulaTxt.Clear();
            contraseñaTxt.Clear();
            cedulaTxt.Focus();
        }

        private void registrarseBtn_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Registrarse(_serviceProvider));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (contraseñaTxt.UseSystemPasswordChar)
            {
                contraseñaTxt.UseSystemPasswordChar = false;
                button2.Text = "Ocultar";
            }
            else
            {
                contraseñaTxt.UseSystemPasswordChar = true;
                button2.Text = "Ver";
            }
        }

        private void Loguearse()
        {
            var usuarioService = _serviceProvider.GetService<UsuarioService>();
            if (usuarioService == null)
            {
                MessageBox.Show("Ocurrió un error inesperado con la base de datos".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!(cedulaTxt.Text.Equals("")) && !(contraseñaTxt.Text.Equals("")))
            {
                ValidacionLogin(usuarioService);
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void ValidacionLogin(UsuarioService usuarioService)
        {
            int resultado = usuarioService.LoginUsuario(cedulaTxt.Text, contraseñaTxt.Text);

            switch (resultado)
            {

                case 0:
                    MessageBox.Show("El usuario no existe en la base de datos".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1:
                    MessageBox.Show("Contraseña incorrecta".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    Usuario usuarioIngresado = usuarioService.BuscarUsuario(cedulaTxt.Text);
                    FrmContenedor principal = new FrmContenedor(usuarioIngresado, _serviceProvider);
                    principal.Show();
                    this.Hide();
                    break;
                case 3:
                    MessageBox.Show("No se pudo ingresar debido a la condición del usuario: (Pendiente de aprobación)".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 4:
                    MessageBox.Show("No se pudo ingresar debido a la condición del usuario: (Rechazado)".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 5:
                    MessageBox.Show("El usuario ya se encuentra conectado".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show("Ocurrió un error en la base de datos".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

            }
        }

        private void AplicarRestriccionesATodos(Control padre)
        {
            foreach (Control control in padre.Controls)
            {
                if (control is System.Windows.Forms.TextBox tb)
                {
                    if (tb.Name == "nombreTxt")
                        continue;
                    tb.KeyPress += TextBox_KeyPress;
                    tb.KeyDown += TextBox_KeyDown;
                    tb.ContextMenuStrip = new ContextMenuStrip();
                }

                if (control.Controls.Count > 0)
                    AplicarRestriccionesATodos(control);
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
                e.SuppressKeyPress = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            AplicarRestriccionesATodos(this);
        }
    }
}
