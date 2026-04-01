using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarPDFUP.Models
{
    [Table("Encargado")]
    public class Encargado
    {
        public string? NombreEncargado { get; set; }
        public string? CedulaEncargado { get; set; }
        public string? Parentesco { get; set; }
        public string? TelefonoEncargado { get; set; }
        public string? LugarTrabajo { get; set; }

        public string? Correo { get; set; }

        public string? NombreContactoEmergencia { get; set; }

        public string? TelefonoContactoEmergencia { get; set; }
        [Key]
        public int IdEncargado { get; set; }
    }
}
