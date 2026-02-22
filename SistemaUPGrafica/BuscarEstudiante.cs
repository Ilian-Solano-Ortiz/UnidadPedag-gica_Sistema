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
namespace SistemaUPGrafica
{
    public partial class BuscarEstudiante : Form
    {
        public Form? FormularioActivo { get; set; }
        public Estudiante? Estudiante { get; set; }
        public Encargado? Encargado { get; set; }

        public BuscarEstudiante()
        {
            InitializeComponent();
            FormularioActivo = null;
           
        }

        private void cerrarSesionBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuariosBtn_Click(object sender, EventArgs e)
        {
            abrirFormulario(new BuscarUsuarios());
        }

        private void abrirFormulario(Form formulario)
        {
            if (FormularioActivo!=null)
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

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            bool existeEstudiante = traerEstudiante();
            bool existeEncargado = traerEncargado();
            if (false)
            {

                MessageBox.Show("El estudiante existe en la base de datos");
                abrirFormulario(new MatriculaExistenteFrm(Estudiante,Encargado));
            }
            else
            {
                MessageBox.Show("El estudiante no existe en la base de datos");
                abrirFormulario(new FrmMatriculaNoExistente());
            }
                
        }


        //Traera la información de los estudiantes de nuestra base de datos
        private bool traerEstudiante()
        {
            this.Estudiante = new Estudiante
            {
                NombreEstudiante = "Ilian",
                CedulaEstudiante = "2343",
                FechaNacimiento = "29/08/2004",
                Direccion = "cariari",
                NivelEstudiante = "Décimo",
                AdecuacionEstudiante = "No",
                EnfermedadEstudiante = "No",
                TratamientoEstudiante = "No",
                Beca = "No",
                TipoBeca = "No"
            };
            return Estudiante!=null;
        }
        //Traera la información de los encargados de nuestra base de datos
        private bool traerEncargado()
        {
            Encargado = new Encargado
            {
                NombreEncargado = "Juan",
                CedulaEncargado = "32432",
                Parentesco = "Padre",
                TelefonoEncargado = "2344",
                LugarTrabajo = "ICE"
            };
            return Encargado!=null;
        }
    }
}
