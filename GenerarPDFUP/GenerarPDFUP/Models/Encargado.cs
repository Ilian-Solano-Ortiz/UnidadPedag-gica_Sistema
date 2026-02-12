using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarPDFUP.Models
{
    public class Encargado
    {
        public string? NombreEncargado { get; set; }
        public string? CedulaEncargado { get; set; }
        public string? Parentesco { get; set; }
        public string? TelefonoEncargado { get; set; }
        public string? LugarTrabajo { get; set; }

        public string? Correo { get; set; }

        public string? ComunicacionEmergencia { get; set; }

        public string? TelefonoEmergencia { get; set; }
        
    }
}
