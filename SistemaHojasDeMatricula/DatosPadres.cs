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
    public partial class DatosPadres : Form
    {
        public DatosPadres()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)//no funciona si se vuelve a presionar
        {
            BuscarEstudiante formPrincipal = (BuscarEstudiante)this.ParentForm;
            formPrincipal.abrirFormulario(new FrmCondicionSocieconomica());
        }

        private void btnAtras_Click(object sender, EventArgs e)//cambié acá
        {
            FrmContenedor principal = (FrmContenedor)Application.OpenForms["FrmContenedor"];

            principal.abrirFormulario(new FrmMatriculaNoExistente());
        }
    }
}
