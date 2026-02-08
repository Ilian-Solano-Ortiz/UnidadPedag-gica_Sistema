using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHojasDeMatricula
{
    public partial class BuscarEstudiante : Form
    {
        public Form FormularioActivo { get; set; }
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

        public void abrirFormulario(Form formulario)
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
            if (true)
            {
                MessageBox.Show("El estudiante existe en la base de datos");
                //abrirFormulario(new MatriculaExistenteFrm());
                abrirFormulario(new FrmMatriculaNoExistente());
            }
            else
            {
                MessageBox.Show("El estudiante no existe en la base de datos");
            }
                
        }
    }
}
