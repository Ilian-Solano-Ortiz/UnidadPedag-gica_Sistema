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

        private string CedulaUsuarioSeleccionado;

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
            var usuarioServicio = ServiceProvider.GetService<UsuarioService>();
            List<Usuario> nuevaLista = new List<Usuario>();
            Usuario usuario = usuarioServicio.BuscarUsuario(buscarTxt.Text.Trim());
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
            var cedulaUsuario = dataGridView1.Rows[e.RowIndex].Cells["CedulaUsuario"].Value;

            if (cedulaUsuario != null)
            {
                CedulaUsuarioSeleccionado = Convert.ToString(cedulaUsuario);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var servicioUsuario = ServiceProvider.GetService<UsuarioService>();
            int resultado= servicioUsuario.AceptarUsuario(this.CedulaUsuarioSeleccionado);
            switch (resultado)
            {
                case 0:
                    MessageBox.Show("El usuario no existe".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    MessageBox.Show("El usuario ha sido aceptado".ToUpper(), "Usuario aceptado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                    break;
                default:
                    MessageBox.Show("Ocurrió un error en la base de datos".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
   
        }

        private void rechazarBtn_Click(object sender, EventArgs e)
        {
            var servicioUsuario = ServiceProvider.GetService<UsuarioService>();
            int resultado = servicioUsuario.RechazarUsuario(this.CedulaUsuarioSeleccionado);
            
            switch (resultado)
            {
                case 0:
                    MessageBox.Show("El usuario no existe".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    MessageBox.Show("El usuario ha sido rechazado".ToUpper(), "Usuario rechazado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                    break;
                default:
                    MessageBox.Show("Ocurrió un error en la base de datos".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
           
        }

        private void refrescarBtn_Click(object sender, EventArgs e)
        {
            var servicioUsuario = ServiceProvider.GetService<UsuarioService>();
            int resultado = servicioUsuario.ResetearContrasena(this.CedulaUsuarioSeleccionado);
            switch (resultado)
            {
                case 0:
                    MessageBox.Show("El usuario no existe".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    MessageBox.Show("Se ha restablecido la contraseña".ToUpper(), "Contraseña restablecida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                    break;
                default:
                    MessageBox.Show("Ocurrió un error en la base de datos".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
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
            usuarios.RemoveAll(u => u.CedulaUsuario == this.Usuario.CedulaUsuario);
        }

        private void btnRefrescarLista_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var servicioUsuario = ServiceProvider.GetService<UsuarioService>();
            int resultado = servicioUsuario.EliminarUsuario(this.CedulaUsuarioSeleccionado);
            switch (resultado)
            {
                case 0:
                    MessageBox.Show("No se pudo eliminar el usuario.\nEl usuario no existe en la base de datos".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1:
                    MessageBox.Show("Usuario eliminado correctamente.".ToUpper(), "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                    break;
                case 2:
                    MessageBox.Show("No se pudo eliminar el usuario.\nEl usuario está conectado".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show("Ocurrió un error en la base de datos".ToUpper(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            var cedula = dataGridView1.SelectedRows[0].Cells["CedulaUsuario"].Value;

            if (cedula != null)
            {
                CedulaUsuarioSeleccionado = Convert.ToString(cedula);
            }
        }
    }
}
