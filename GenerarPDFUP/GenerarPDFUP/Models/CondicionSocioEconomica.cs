using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarPDFUP.Models
{
    public class CondicionSocioEconomica
    {
        public string? TieneBeca { get; set; }
        public string? TipoBeca { get; set; }
        public string? NucleoFamiliar { get; set; }

        public string? PagoPatronato { get; set; }
        public string? Monto { get; set; }

        public string? EducacionEncargado { get; set; }
    }
}
