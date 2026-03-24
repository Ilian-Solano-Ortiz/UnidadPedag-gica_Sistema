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
            if (textBox2.UseSystemPasswordChar)
            {
                textBox2.UseSystemPasswordChar = false;
                button2.Text = "Ocultar";
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                button2.Text = "Ver";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.UseSystemPasswordChar)
            {
                textBox1.UseSystemPasswordChar = false;
                button1.Text = "Ocultar";
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
                button1.Text = "Ver";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.UseSystemPasswordChar)
            {
                textBox3.UseSystemPasswordChar = false;
                button3.Text = "Ocultar";
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
                button3.Text = "Ver";
            }
        }

        private void cambiarContraseña()
        {
            var usuarioServicio = _serviceProvider.GetService<UsuarioService>();
            if (!(textBox1.Text.Equals("")) && !(textBox2.Text.Equals("")) && !(textBox3.Text.Equals("")))
            {
                if (textBox2.Text.Equals(Usuario.ContrasenaUsuario))
                {
                    if (textBox3.Text.Equals(textBox1.Text))
                    {
                        if (textBox3.Text.Length < 8)
                        {
                            MessageBox.Show("La contraseña debe contar con al menos 8 carácteres".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            usuarioServicio.ActualizarPropiedadUsuario(this.Usuario.IdUsuario, "Contraseña", textBox3.Text);
                            MessageBox.Show($"La contraseña se ha actualizado {this.Usuario.IdUsuario}".ToUpper(), "Aceptado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("La contraseña de confirmación no coincide".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña anterior no coincide".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
