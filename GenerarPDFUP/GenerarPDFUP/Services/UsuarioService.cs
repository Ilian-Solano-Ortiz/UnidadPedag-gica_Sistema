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
                    CondicionLogin="Disponible"
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
                    usuario.CondicionLogin = valorPropiedad;
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


        // =====================================================
        // REGISTRAR USUARIO
        // Retorna: 0 = ya existe | 1 = creado correctamente
        // =====================================================
        public int RegistrarUsuario(string cedula, string nombre, string contrasena, string rol)
        {
            try
            {
                var resultado = Context.ResultadoDto
                    .FromSqlRaw("CALL RegistrarUsuario({0}, {1}, {2}, {3})",
                        cedula, nombre, contrasena, rol)
                    .AsEnumerable()
                    .FirstOrDefault();

                return resultado?.Resultado ?? -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inesperado: " + e.Message);
                return -1;
            }
        }

        // =====================================================
        // LOGIN USUARIO
        // Retorna: 0 = no existe | 1 = contraseña incorrecta
        //          2 = login correcto | 3 = pendiente
        //          4 = rechazado | 5 = ya conectado
        // =====================================================
        public int LoginUsuario(string cedula, string contrasena)
        {
            try
            {
                var resultado = Context.ResultadoDto
                    .FromSqlRaw("CALL LoginUsuario({0}, {1})", cedula, contrasena)
                    .AsEnumerable()
                    .FirstOrDefault();

                return resultado?.Resultado ?? -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inesperado: " + e.Message);
                return -1;
            }
        }

        // =====================================================
        // LOGOUT USUARIO
        // Retorna: 1 = desconectado correctamente
        // =====================================================
        public int LogoutUsuario(string cedula)
        {
            try
            {
                var resultado = Context.ResultadoDto
                    .FromSqlRaw("CALL LogoutUsuario({0})", cedula)
                    .AsEnumerable()
                    .FirstOrDefault();

                return resultado?.Resultado ?? -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inesperado: " + e.Message);
                return -1;
            }
        }

        // =====================================================
        // CAMBIAR CONTRASEÑA
        // Retorna: 0 = no existe | 1 = contraseña actual incorrecta
        //          2 = cambiada correctamente
        // =====================================================
        public int CambiarContrasena(string cedula, string contrasenaActual, string contrasenaNueva)
        {
            try
            {
                var resultado = Context.ResultadoDto
                    .FromSqlRaw("CALL CambiarContrasena({0}, {1}, {2})",
                        cedula, contrasenaActual, contrasenaNueva)
                    .AsEnumerable()
                    .FirstOrDefault();

                return resultado?.Resultado ?? -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inesperado: " + e.Message);
                return -1;
            }
        }

        // =====================================================
        // RESETEAR CONTRASEÑA
        // Retorna: 0 = no existe | 1 = reseteada correctamente
        // =====================================================
        public int ResetearContrasena(string cedula)
        {
            try
            {
                var resultado = Context.ResultadoDto
                    .FromSqlRaw("CALL ResetearContrasena({0})", cedula)
                    .AsEnumerable()
                    .FirstOrDefault();

                return resultado?.Resultado ?? -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inesperado: " + e.Message);
                return -1;
            }
        }

        // =====================================================
        // ACEPTAR USUARIO
        // Retorna: 0 = no existe | 1 = aceptado correctamente
        // =====================================================
        public int AceptarUsuario(string cedula)
        {
            try
            {
                var resultado = Context.ResultadoDto
                    .FromSqlRaw("CALL AceptarUsuario({0})", cedula)
                    .AsEnumerable()
                    .FirstOrDefault();

                return resultado?.Resultado ?? -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inesperado: " + e.Message);
                return -1;
            }
        }

        // =====================================================
        // RECHAZAR USUARIO
        // Retorna: 0 = no existe | 1 = rechazado correctamente
        // =====================================================
        public int RechazarUsuario(string cedula)
        {
            try
            {
                var resultado = Context.ResultadoDto
                    .FromSqlRaw("CALL RechazarUsuario({0})", cedula)
                    .AsEnumerable()
                    .FirstOrDefault();

                return resultado?.Resultado ?? -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inesperado: " + e.Message);
                return -1;
            }
        }

        // =====================================================
        // BUSCAR USUARIO POR CEDULA
        // Retorna el Usuario si existe, null si no
        // =====================================================
        public Usuario BuscarUsuario(string cedula)
        {
            try
            {
                return Context.Usuarios
                    .FromSqlRaw("CALL BuscarUsuario({0})", cedula)
                    .AsEnumerable()
                    .FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inesperado: " + e.Message);
                return null;
            }
        }

        // =====================================================
        // MODIFICAR USUARIO
        // Retorna: 0 = no existe | 1 = actualizado
        //          2 = cédula nueva ya existe
        // =====================================================
        public int ModificarUsuario(string cedulaActual, string nuevaCedula, string nombre, string rol)
        {
            try
            {
                var resultado = Context.ResultadoDto
                    .FromSqlRaw("CALL ModificarUsuario({0}, {1}, {2}, {3})",
                        cedulaActual, nuevaCedula, nombre, rol)
                    .AsEnumerable()
                    .FirstOrDefault();

                return resultado?.Resultado ?? -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inesperado: " + e.Message);
                return -1;
            }
        }

        // =====================================================
        // ELIMINAR USUARIO
        // Retorna: 0 = no existe | 1 = eliminado
        //          2 = usuario está conectado
        // =====================================================
        public int EliminarUsuario(string cedula)
        {
            try
            {
                var resultado = Context.ResultadoDto
                    .FromSqlRaw("CALL EliminarUsuario({0})", cedula)
                    .AsEnumerable()
                    .FirstOrDefault();

                return resultado?.Resultado ?? -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inesperado: " + e.Message);
                return -1;
            }
        }


    }
}
