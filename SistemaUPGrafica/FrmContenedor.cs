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
using GenerarPDFUP.Services;

namespace SistemaUPGrafica
{
    public partial class FrmContenedor : Form
    {
        public Form FormularioActivo { get; set; }
        public Usuario Usuario { get; set; }

        private readonly IServiceProvider _serviceProvider;
        private bool _cerrandoSesion  = false;

        public FrmContenedor( Usuario usuario, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            usuariosBtn.Visible = false;
            FormularioActivo = null;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;   // Quita botón maximizar
            this.MinimizeBox = false;   // Quita botón minimizar
            this.FormClosing += (s, e) =>
            {
                
                if (!_cerrandoSesion) 
                {
                   var usuarioServicio= _serviceProvider.GetService<UsuarioService>();
                   usuarioServicio.ActualizarPropiedadUsuario(this.Usuario.IdUsuario,"Estado","Disponible"); 
                    Application.Exit();
                }
            };
            _serviceProvider = serviceProvider;
            this.Usuario=usuario;

            if (this.Usuario.RolUsuario.Equals("Administrador"))
            {
                usuariosBtn.Visible = true;
            }
        }

        //CAMBIO DE CÓDIGO PARA QUE LIMPIE CAMPO DE USUARIO Y CONTRASEÑA AL CERRAR SESIÓN
        private void cerrarSesionBtn_Click(object sender, EventArgs e) 
        {
            _cerrandoSesion = true;
            Login login = Application.OpenForms["Login"] as Login;

              if (login != null)
              {
                  login.LimpiarCampos();
                  login.Show();
              }
            var usuarioServicio = _serviceProvider.GetService<UsuarioService>();
            usuarioServicio.ActualizarPropiedadUsuario(this.Usuario.IdUsuario,"Estado","Disponible");
            this.Close();
        }
        private void abrirFormulario(Form formulario)
        {
            if (FormularioActivo != null)
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
        private void estudiantesBtn_Click(object sender, EventArgs e)
        {
            abrirFormulario(new BuscarEstudiante());
        }

        private void usuariosBtn_Click(object sender, EventArgs e)
        {
            abrirFormulario(new BuscarUsuarios(this.Usuario,this._serviceProvider));
        }

        private void cambiarContraBtn_Click(object sender, EventArgs e)
        {
            abrirFormulario(new CambioContra(this.Usuario, this._serviceProvider));
        }
    }
}
