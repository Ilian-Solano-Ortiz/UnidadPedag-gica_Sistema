using GenerarPDFUP.Data;
using GenerarPDFUP.Models;
using Microsoft.EntityFrameworkCore;
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

        public List<Estudiante> ObtenerTodosEstudiantes()
        {
            return matriculasContext.Estudiantes.ToList();
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
    }
}
