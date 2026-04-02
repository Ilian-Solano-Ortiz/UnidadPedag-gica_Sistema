using GenerarPDFUP.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaUPGrafica
{
    public partial class Registrarse : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public Registrarse(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrarseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var servicioUsuario = _serviceProvider.GetService<UsuarioService>();

                if (!(nombreTxt.Text.Equals("")) && !(contrasenaTxt.Text.Equals("")) && !(confirmarContraTxt.Text.Equals(""))
                    && !(cedulaTxt.Text.Equals("")))
                {
                    if (contrasenaTxt.Text.Equals(confirmarContraTxt.Text))
                    {
                        if (confirmarContraTxt.Text.Length < 8)
                        {
                            MessageBox.Show("La contraseña debe contar con al menos 8 carácteres".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            ValidacionRegistrarse(servicioUsuario);

                        }

                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (contrasenaTxt.UseSystemPasswordChar)
            {
                contrasenaTxt.UseSystemPasswordChar = false;
                button1.Text = "Ocultar";
            }
            else
            {
                contrasenaTxt.UseSystemPasswordChar = true;
                button1.Text = "Ver";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (confirmarContraTxt.UseSystemPasswordChar)
            {
                confirmarContraTxt.UseSystemPasswordChar = false;
                button2.Text = "Ocultar";
            }
            else
            {
                confirmarContraTxt.UseSystemPasswordChar = true;
                button2.Text = "Ver";
            }
        }

        private void ValidacionRegistrarse(UsuarioService servicioUsuario)
        {
            int resultado = servicioUsuario.RegistrarUsuario(cedulaTxt.Text, nombreTxt.Text, confirmarContraTxt.Text, "funcionario");
            if (resultado == -1)
            {
                MessageBox.Show("Ha ocurrido un error inesperado en la base de datos".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (resultado == 1)
            {
                MessageBox.Show("Su usuario se ha registrado correctamente y está en pendiente".ToUpper(), "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("La cédula ya está asociada a otro usuario, por favor intente con otra cédula".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Registrarse_Load_1(object sender, EventArgs e)
        {
            AplicarRestriccionesATodos(this);
        }
    }
}
