using GenerarPDFUP.Models;
using GenerarPDFUP.Services;
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
    public partial class BuscarUsuarios : Form
    {
        private readonly IServiceProvider ServiceProvider;
        public Usuario Usuario { get; set; }

        private int IdUsuarioSeleccionado;

        private List<Usuario> usuarios;
        public BuscarUsuarios(Usuario usuario, IServiceProvider serviceProvider)
        {
            usuarios = new List<Usuario>();
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.ServiceProvider = serviceProvider;
            this.Usuario = usuario;
            llenarDataGrid();
        }

        private void cerrarSesionBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void estudiantesBtn_Click(object sender, EventArgs e)
        {
            abrirFormulario(new BuscarEstudiante());
        }

        private void abrirFormulario(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.BringToFront();
            this.Close();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (buscarTxt.Text.Trim().Equals(""))
            {
                return;
            }
            List<Usuario> nuevaLista = new List<Usuario>();
            Usuario usuario=usuarios.Find(u=>u.NombreUsuario.Equals(buscarTxt.Text.Trim()));
            nuevaLista.Add(usuario);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = nuevaLista;
            dataGridView1.Columns["IdUsuario"].Visible = false;
            dataGridView1.Columns["ContrasenaUsuario"].Visible = false;

        }

        private void llenarDataGrid()
        {
            LlenarListaUsuarios();
            BindingSource bs = new BindingSource();
            bs.DataSource = usuarios;
            dataGridView1.DataSource = bs;
            dataGridView1.Columns["IdUsuario"].Visible = false;
            dataGridView1.Columns["ContrasenaUsuario"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var idUsuario = dataGridView1.Rows[e.RowIndex].Cells["IdUsuario"].Value;

            if (idUsuario != null)
            {
                
                IdUsuarioSeleccionado = Convert.ToInt32(idUsuario);
                
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var servicioUsuario = ServiceProvider.GetService<UsuarioService>();
            MessageBox.Show("El usuario ha sido aceptado".ToUpper(), "Usuario aceptado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            servicioUsuario.ActualizarPropiedadUsuario(this.IdUsuarioSeleccionado, "Condicion", "Aceptado");
            CargarDatos();
        }

        private void rechazarBtn_Click(object sender, EventArgs e)
        {
            var servicioUsuario = ServiceProvider.GetService<UsuarioService>();
            MessageBox.Show("El usuario ha sido rechazado".ToUpper(), "Usuario rechazado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            servicioUsuario.ActualizarPropiedadUsuario(this.IdUsuarioSeleccionado, "Condicion", "Rechazado");
            CargarDatos();
        }

        private void refrescarBtn_Click(object sender, EventArgs e)
        {
            var servicioUsuario = ServiceProvider.GetService<UsuarioService>();
            if (this.IdUsuarioSeleccionado < 0)
            {
                return;
            }

            Usuario usuarioEncontrado = usuarios.Find(u => u.IdUsuario == IdUsuarioSeleccionado);
            servicioUsuario.ActualizarPropiedadUsuario(this.IdUsuarioSeleccionado, "Contraseña", usuarioEncontrado.NombreUsuario + usuarioEncontrado.RolUsuario);
            MessageBox.Show("Se ha restablecido la contraseña del usuario (Nombre + rol)".ToUpper(), "Cambio correcto",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarDatos();
        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = null;
            LlenarListaUsuarios();
            dataGridView1.DataSource = usuarios;
            dataGridView1.Columns["IdUsuario"].Visible = false;
            dataGridView1.Columns["ContrasenaUsuario"].Visible = false;
        }

        private void LlenarListaUsuarios()
        {
            usuarios.Clear();
            var servicioUsuario = ServiceProvider.GetService<UsuarioService>();
            usuarios = servicioUsuario.ObtenerUsuarios();
            usuarios.Remove(this.Usuario);
        }

        private void btnRefrescarLista_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var servicioUsuario = ServiceProvider.GetService<UsuarioService>();
            if (servicioUsuario.EliminarUsuario(IdUsuarioSeleccionado))
            {
                MessageBox.Show("Usuario eliminado correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
            }
            else
                MessageBox.Show("No se pudo eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
