using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarPDFUP.Models
{
    public class Estudiante
    {
        public string? NombreEstudiante { get; set; }
        public string? CedulaEstudiante { get; set; }
        public string? FechaNacimiento { get; set; }
        public string? Direccion { get; set; }
        //Representa el grado
        public string? NivelEstudiante { get; set; }
        public string? AdecuacionEstudiante { get; set; }
        public string?  EnfermedadEstudiante { get; set; }
        public string? TratamientoEstudiante { get; set; }
        public string? Beca { get; set; }
        public string? TipoBeca { get; set; }

        public string? FechaMatricula { get; set; }

        public string? HorasTC { get; set; }

        public string? IdiomaElegido { get; set; }

        public string? AdecuacionAprobada { get; set; }
        
        //Representa el nivel de educación (preescolar, primaria, secundaria)
        public string? NivelSeleccionado { get; set; }
    }
}
