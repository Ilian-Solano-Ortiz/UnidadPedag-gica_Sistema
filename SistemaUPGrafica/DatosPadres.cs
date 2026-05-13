using GenerarPDFUP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace SistemaUPGrafica
{
    public partial class DatosPadres : Form
    {
        
        public Form PanelCondicion { get; set; }
        public Estudiante? Estudiante { get; set; }
        public Encargado? Encargado { get; set;}

        private readonly IServiceProvider _serviceProvider;
        public Usuario Usuario { get; set; }

        private readonly Action _volverABuscarEstudiante;
        public DatosPadres(Estudiante Estudiante, IServiceProvider serviceProvider, Usuario usuario, Action volverABuscarEstudiante)
        {
            InitializeComponent();
            this._serviceProvider = serviceProvider;
            this.Estudiante = Estudiante;
            this.Usuario = usuario;
            this.Encargado = new Encargado();
            
            this._volverABuscarEstudiante = volverABuscarEstudiante;
            generarPanelCondicion();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtNombreEncargado.Text.Trim().Equals(""))
            {
                MessageBox.Show("El campo de nombre del encargado es obligatorio.".ToUpper(), "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textCed.Text.Trim().Equals(""))
            {
                MessageBox.Show("El campo de cédula del encargado es obligatorio.".ToUpper(), "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (textTel.Text.Trim().Equals(""))
            {
                MessageBox.Show("El campo de teléfono es obligatorio.".ToUpper(), "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (correoTxt.Text.Trim().Equals(""))
            {
                MessageBox.Show("El campo de correo electrónico es obligatorio.".ToUpper(), "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }            

           
            if (!ValidarTelefono(textTel.Text.Trim()))
            {
                MessageBox.Show("El teléfono debe tener el formato: 6230-1020", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidarCorreo(correoTxt.Text.Trim()))
            {
                MessageBox.Show("El correo debe tener un formato válido. Ejemplo: ejemplo@gmail.com", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!txtEmergencia1.Text.Equals(""))
            {
                if (txtTelEmer1.Text.Equals("") && txtTelEmer2.Text.Equals(""))
                {
                    MessageBox.Show("El contacto de emergencia debe tener un número telefónico", "Faltán campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (!(txtTelEmer1.Text.Equals("")))
            {
                if (!ValidarTelefono(txtTelEmer1.Text.Trim()))
                {
                    MessageBox.Show("El teléfono de emergencia 1 debe tener el formato: 6230-1020", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (!(txtTelEmer2.Text.Equals("")))
            {
                if (!ValidarTelefono(txtTelEmer2.Text.Trim()))
                {
                    MessageBox.Show("El teléfono de emergencia 2 debe tener el formato: 6230-1020", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (!txtTelEmer1.Text.Equals("") || !txtTelEmer2.Text.Equals(""))
            {
                if (txtEmergencia1.Text.Equals(""))
                {
                    MessageBox.Show("Los números de emergencia deben estar asociados a un contacto de emergencia", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            editarInformacionPadres();         
            PanelCondicion.Show();
            PanelCondicion.BringToFront();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void generarPanelCondicion()
        {
            this.PanelCondicion = new FrmCondicionSocieconomica(this.Estudiante, this.Encargado, this._serviceProvider, this.Usuario, this._volverABuscarEstudiante);
            this.PanelCondicion.FormBorderStyle = FormBorderStyle.None;
            this.PanelCondicion.TopLevel = false;
            this.PanelCondicion.Dock = DockStyle.None;
            this.Controls.Add(PanelCondicion);
        }

        private void editarInformacionPadres()
        {
            this.Encargado.NombreEncargado = txtNombreEncargado.Text;
            this.Encargado.CedulaEncargado = textCed.Text;
            this.Encargado.Correo = correoTxt.Text;
            this.Encargado.LugarTrabajo = txtTrabajo.Text;
            this.Encargado.Parentesco = textParentesco.Text;
            this.Encargado.TelefonoEncargado = textTel.Text;
            this.Encargado.NombreContactoEmergencia = txtEmergencia1.Text;
            this.Encargado.TelefonoContactoEmergencia = txtTelEmer1.Text+","+txtTelEmer2.Text;
            
        }

        private bool ValidarTelefono(string telefono)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^\d{4}-\d{4}$");
            return regex.IsMatch(telefono);
        }

        private bool ValidarCorreo(string correo)
        {
            return correo.Contains("@") && correo.Contains(".");
        }

    }
}
