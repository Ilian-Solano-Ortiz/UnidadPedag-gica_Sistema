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
            var usuarioService = _serviceProvider.GetService<UsuarioService>();
            Usuario usuarioIngresado = new Usuario() {NombreUsuario = usuarioTxt.Text, ContrasenaUsuario = contraseñaTxt.Text};

            if (!(usuarioTxt.Text.Equals(""))&&!(contraseñaTxt.Text.Equals("")))
            {
                if (usuarioService.ExisteUsuario(usuarioIngresado))
                {
                    usuarioIngresado = usuarioService.RetornarUsuario(usuarioIngresado);
                    string estadoUsuario = usuarioIngresado.CondicionLogin.Trim().ToLower();
                    string condicionUsuario = usuarioIngresado.CondicionAceptacion.Trim().ToLower();

                    if (condicionUsuario.Equals("aceptado") || usuarioIngresado.RolUsuario.Equals("Administrador"))
                    {
                        if (estadoUsuario.Equals("disponible") || usuarioIngresado.RolUsuario.Equals("Administrador"))
                        {
                            usuarioService.ActualizarPropiedadUsuario(usuarioIngresado.IdUsuario,"Estado","Ocupado");
                            FrmContenedor principal = new FrmContenedor(usuarioIngresado,_serviceProvider);
                            principal.Show();
                            this.Hide();
                            
                        }
                        else
                        {
                            MessageBox.Show($"No se pudo ingresar debido al estado del usuario: ({usuarioIngresado.CondicionLogin})".ToUpper(), "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"No se pudo ingresar debido a la condición del usuario: ({usuarioIngresado.CondicionAceptacion})".ToUpper(),
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("El usuario no se econtró en la base de datos\nUsuario Y/O contraseña incorrectos".ToUpper(),
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // LO QUE HACE ES LIMPIAR LOS CAMPOS DE USUARIO Y CONTRASEÑA CUANDO SE CIERRA SESIÓN
        public void LimpiarCampos()
        {
            usuarioTxt.Clear();
            contraseñaTxt.Clear();
            usuarioTxt.Focus();
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

        
    }
}
