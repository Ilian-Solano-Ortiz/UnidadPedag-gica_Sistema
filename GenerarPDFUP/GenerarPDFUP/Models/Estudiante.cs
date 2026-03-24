using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarPDFUP.Models
{
    [Table("Estudiante")]
    public class Estudiante
    {
        public string? NombreEstudiante { get; set; }
        public string? CedulaEstudiante { get; set; }
        public string? FechaNacimiento { get; set; }
        public string? Direccion { get; set; }

        //Representa el grado
        [NotMapped]
        public string? NivelEstudiante { get; set; }

        [NotMapped]
        public string? AdecuacionEstudiante { get; set; }

        [NotMapped]
        public string?  EnfermedadEstudiante { get; set; }

        [NotMapped]
        public string? TratamientoEstudiante { get; set; }

        [NotMapped]
        public string? Beca { get; set; }

        [NotMapped]
        public string? TipoBeca { get; set; }

        [NotMapped]
        public string? FechaMatricula { get; set; }

        [NotMapped]
        public string? HorasTC { get; set; }

        [NotMapped]
        public string? IdiomaElegido { get; set; }

        [NotMapped]
        public string? AdecuacionAprobada { get; set; }

        //Representa el nivel de educación (preescolar, primaria, secundaria)
        [NotMapped]
        public string? NivelSeleccionado { get; set; }

        [NotMapped]
        public string? AlergicoMedicamento { get; set; }

        [Key]
        public int IdEstudiante { get; set; }
    }
}
