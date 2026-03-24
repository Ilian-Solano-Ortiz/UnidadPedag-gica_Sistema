using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarPDFUP.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string? NombreUsuario { get; set; }
        public string? ContrasenaUsuario { get; set; }
        public string? RolUsuario { get; set; }
        public string? CondicionAceptacion { get; set; }
        public string? Estado { get; set; }
    }
}
