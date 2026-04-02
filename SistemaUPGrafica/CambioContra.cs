using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenerarPDFUP.Models;
using GenerarPDFUP.Services;
using Microsoft.Extensions.DependencyInjection;

namespace SistemaUPGrafica
{
    public partial class CambioContra : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public Usuario Usuario { get; set; }

        public CambioContra(Usuario usuario, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            Usuario = usuario;
            this.label5.Text += this.Usuario.NombreUsuario;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (contraAnteriorTxt.UseSystemPasswordChar)
            {
                contraAnteriorTxt.UseSystemPasswordChar = false;
                button2.Text = "Ocultar";
            }
            else
            {
                contraAnteriorTxt.UseSystemPasswordChar = true;
                button2.Text = "Ver";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (contraNuevaTxt.UseSystemPasswordChar)
            {
                contraNuevaTxt.UseSystemPasswordChar = false;
                button1.Text = "Ocultar";
            }
            else
            {
                contraNuevaTxt.UseSystemPasswordChar = true;
                button1.Text = "Ver";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void cambiarContraseña()
        {
            var usuarioServicio = _serviceProvider.GetService<UsuarioService>();
            if (usuarioServicio == null)
            {
                MessageBox.Show("Ocurrió un error con la base de datos".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(contraNuevaTxt.Text.Equals("")) && !(contraAnteriorTxt.Text.Equals("")))
            {
                if (contraNuevaTxt.Text.Length < 8)
                {
                    MessageBox.Show("La contraseña debe contar con al menos 8 carácteres".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    int resultado = usuarioServicio.CambiarContrasena(this.Usuario.CedulaUsuario, contraAnteriorTxt.Text.Trim(), contraNuevaTxt.Text.Trim());
                    switch (resultado)
                    {
                        case 0:
                            MessageBox.Show("El usuario no se pudo encontrar en la base de datos".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 1:
                            MessageBox.Show("La contraseña actual es incorrecta".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 2:
                            MessageBox.Show("La contraseña se cambió exitosamente".ToUpper(), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            contraNuevaTxt.Text = "";
                            contraAnteriorTxt.Text = "";
                            break;
                        default:
                            MessageBox.Show("Ocurrió un error con la base de datos".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }

            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void confirmarBtn_Click(object sender, EventArgs e)
        {
            cambiarContraseña();
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

        private void CambioContra_Load(object sender, EventArgs e)
        {
            AplicarRestriccionesATodos(this);
        }
    }
}
