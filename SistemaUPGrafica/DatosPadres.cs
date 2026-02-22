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

namespace SistemaUPGrafica
{
    public partial class DatosPadres : Form
    {
        
        public Form PanelCondicion { get; set; }
        public Estudiante? Estudiante { get; set; }
        public Encargado? Encargado { get; set;}
                
        public DatosPadres(Estudiante Estudiante)
        {
            InitializeComponent();
            
            this.Estudiante = Estudiante;
            this.Encargado = new Encargado();
            generarPanelCondicion();
          
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
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
            this.PanelCondicion = new FrmCondicionSocieconomica(this.Estudiante, this.Encargado);
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
            this.Encargado.ComunicacionEmergencia = txtEmergencia1.Text+","+txtEmergencia2.Text;
            this.Encargado.TelefonoEmergencia = txtTelEmer1.Text+","+txtTelEmer2.Text;
        }
    }
}
