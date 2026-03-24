using GenerarPDFUP.Data;
using GenerarPDFUP.Models;
using iTextSharp.text.pdf.codec.wmf;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarPDFUP.Services
{
    public class UsuarioService
    {
        private readonly MatriculasContext Context;
        
        public UsuarioService(MatriculasContext Context) { 
            this.Context = Context;
        }

        public List<Usuario> ObtenerUsuarios()
        {
            try
            {
                return this.Context.Usuarios.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ha ocurrido un error {ex}");
                return new List<Usuario>();
            }
            
        }

        
        public bool ExisteUsuario(Usuario usuario)
        {
            try
            {
                List<Usuario> listaUsuarios = ObtenerUsuarios();
                foreach (Usuario item in listaUsuarios)
                {
                    if (item.NombreUsuario.Equals(usuario.NombreUsuario)
                        && item.ContrasenaUsuario.Equals(usuario.ContrasenaUsuario))
                    {
                        return true;
                    } 
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ha ocurrido un error {ex}");
                return false;
            }
        }

        
        public Usuario RetornarUsuario(Usuario usuario)
        {
            try
            {
                List<Usuario> listaUsuarios = ObtenerUsuarios();
                foreach (Usuario item in listaUsuarios)
                {
                    if (item.NombreUsuario.Equals(usuario.NombreUsuario)
                        && item.ContrasenaUsuario.Equals(usuario.ContrasenaUsuario))
                    {
                        return item;
                    }
                }
                return new Usuario();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ha ocurrido un error {ex}");
                return new Usuario();
            }
        }

        public bool RegistrarUsuario(string nombre, string contrasena)
        {
            try
            {
                Usuario usuarioNuevo = new Usuario()
                {
                    NombreUsuario = nombre,
                    ContrasenaUsuario = contrasena,
                    RolUsuario = "funcionario",
                    CondicionAceptacion = "En espera",
                    Estado="Disponible"
                };
                Context.Usuarios.Add(usuarioNuevo);
                Context.SaveChanges();
                return true;
            }
            catch (DbUpdateException dbEx)
            {
                Console.WriteLine("Error al guardar en la base de datos: " + dbEx.Message);
                return false;
            }
            catch(Exception e)
            {
                Console.WriteLine("Ha ocurrido un error inesperado: "+e);
                return false;
            }
            
        }

        

        public void ActualizarPropiedadUsuario(int idUsuario, string propiedad, string valorPropiedad)
        {
            try
            {
                
                var usuario = Context.Usuarios.FirstOrDefault(u => u.IdUsuario == idUsuario);

                if (usuario == null)
                {
                    Console.WriteLine("No se encontró el usuario con Id: " + idUsuario);
                    return;
                }

                
                if (propiedad.Equals("Estado"))
                {
                    usuario.Estado = valorPropiedad;
                }
                else if (propiedad.Equals("Condicion"))
                {
                    usuario.CondicionAceptacion = valorPropiedad;
                }
                else if (propiedad.Equals("Contraseña"))
                {
                    usuario.ContrasenaUsuario = valorPropiedad;
                }

                
                Context.SaveChanges();
            }
            catch (DbUpdateException dbEx)
            {
                Console.WriteLine("Error al actualizar usuario: " + dbEx.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inesperado: " + e.Message);
            }
        }

        public bool EliminarUsuario(int idUsuario)
        {
            try
            {
                var usuario = Context.Usuarios.FirstOrDefault(u => u.IdUsuario == idUsuario);

                if (usuario == null)
                {
                    Console.WriteLine("No se encontró el usuario con Id: " + idUsuario);
                    return false;
                }

                Context.Usuarios.Remove(usuario);
                Context.SaveChanges();
                return true;
            }
            catch (DbUpdateException dbEx)
            {
                Console.WriteLine("Error al eliminar usuario: " + dbEx.Message);
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inesperado: " + e.Message);
                return false;
            }
        }

    }
}
