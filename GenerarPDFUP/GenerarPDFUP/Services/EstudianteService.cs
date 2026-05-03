using GenerarPDFUP.Data;
using GenerarPDFUP.Models;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarPDFUP.Services
{
    public class EstudianteService
    {
        private readonly MatriculasContext matriculasContext;

        public EstudianteService(MatriculasContext context)
        {
            this.matriculasContext = context;
        }



   public ResultadoMatriculaDto RegistrarMatricula(
    int idUsuario,
    string cedulaEstudiante,
    string nombreEstudiante,
    string fechaNacimiento,
    string direccion,
    string cedulaEncargado,
    string nombreEncargado,
    string telefonoEncargado,
    string parentesco,
    string lugarTrabajo,
    string correo,
    string nombreContactoEmergencia,
    string telefonoEmergencia,
    string fechaMatricula,
    string annoLectivo,
    string nivelSeleccionado,
    string idiomaElegido)
   {
            try
            {
                var resultado = matriculasContext.ResultadoMatriculaDto
                    .FromSqlRaw(
                        "CALL RegistrarMatricula({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16})",
                        idUsuario,
                        cedulaEstudiante,
                        nombreEstudiante,
                        fechaNacimiento,
                        direccion,
                        cedulaEncargado,
                        nombreEncargado,
                        telefonoEncargado,
                        parentesco,
                        lugarTrabajo,
                        correo,
                        nombreContactoEmergencia,
                        telefonoEmergencia,
                        fechaMatricula,
                        annoLectivo,
                        nivelSeleccionado,
                        idiomaElegido)
                    .AsNoTracking()
                    .AsEnumerable()
                    .FirstOrDefault();

                return resultado;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inesperado: " + e.ToString());
                return new ResultadoMatriculaDto { Resultado = 2 };
            }
   }
        public ResultadoDto registrarEstudianteExcel(
            string cedulaEstudiante,
            string nombreEstudiante,
            string cedulaEncargado,
            string nombreEncargado,
            string telefonoEncargado,
            string direccion
            )
        {
            try
            {
                var resultado = matriculasContext.ResultadoDto
                    .FromSqlRaw(
                        "CALL RegistrarEstudianteExcel({0},{1},{2},{3},{4},{5})",
                        cedulaEstudiante,
                        nombreEstudiante,
                        direccion,
                        cedulaEncargado,
                        nombreEncargado,
                        telefonoEncargado)
                    .AsNoTracking()
                    .AsEnumerable()
                    .FirstOrDefault();

                return resultado;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inesperado: " + e.ToString());
                return new ResultadoDto { Resultado = 3 };
            }
        }

        public Estudiante obtenerEstudiante(string cedulaEstudiante)
        {
            try
            {
                var estudiante = matriculasContext.Estudiantes
                    .FromSqlRaw(
                        "CALL ObtenerEstudiante({0})",
                        cedulaEstudiante)
                    .AsNoTracking()
                    .AsEnumerable()
                    .FirstOrDefault();

                        // Si EF mapeó la fila del "SELECT 0 AS Resultado",
                        // el IdEstudiante será 0 y CedulaEstudiante será null
                        if (estudiante == null || estudiante.IdEstudiante == 0)
                        return null;

                        return estudiante;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inesperado: " + e.ToString());
                return null;
            }
        }

        public List<Encargado> obtenerEncargadosEstudiante(string cedulaEstudiante)
        {
            try
            {
                var encargados = matriculasContext.Encargados
                    .FromSqlRaw(
                        "CALL ObtenerEncargadosPorCedula({0})",
                        cedulaEstudiante)
                    .AsNoTracking()
                    .AsEnumerable()
                    .Where(e => e.IdEncargado != 0)  // filtrar fila del "SELECT 0"
                    .ToList();

                return encargados.Count > 0 ? encargados : null;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inesperado: " + e.ToString());
                return null;
            }
        }

        public ResultadoMatriculaDto MatriculaEstudianteExistente(
            int idUsuario,
            int idEstudiante,
            string CedulaEstudiante,
            string NombreEstudiante,
            int idEncargado,
            string cedulaEncargado,
            string nombreEncargado,
            string telefonoEncargado,
            string correo,
            string fechaMatricula,
            string annoLectivo,
            string nivelSeleccionado,
            string idiomaElegido)
        {
            try
            {
                var resultado = matriculasContext.ResultadoMatriculaDto
                    .FromSqlRaw(
                        "CALL MatriculaEstudianteExistente({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12})",
                        idUsuario,
                        idEstudiante,
                        CedulaEstudiante,
                        NombreEstudiante,
                        idEncargado,
                        cedulaEncargado,   // ✅ agregado correctamente
                        nombreEncargado,
                        telefonoEncargado,
                        correo,
                        fechaMatricula,
                        annoLectivo,
                        nivelSeleccionado,
                        idiomaElegido)
                    .AsNoTracking()
                    .AsEnumerable()
                    .FirstOrDefault();
                return resultado;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inesperado: " + e.ToString());
                return new ResultadoMatriculaDto { Resultado = 2 };
            }
        }
    }
}
