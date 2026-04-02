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
                return this.Context.Usuarios.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ha ocurrido un error {ex}");
                return new List<Usuario>();
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
                Console.WriteLine(e.ToString()); 
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
                    .AsNoTracking()
                    .AsEnumerable()
                    .FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inesperado: " + e.ToString());
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
