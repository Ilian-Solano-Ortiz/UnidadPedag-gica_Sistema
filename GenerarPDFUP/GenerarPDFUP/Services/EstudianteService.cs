using GenerarPDFUP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenerarPDFUP.Models;

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
    }
}
