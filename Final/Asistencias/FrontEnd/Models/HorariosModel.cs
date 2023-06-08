using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontEnd.Models
{
    public class HorariosModel
    {
        
        public Guid Id { get; set; }
        public string hsDesde { get; set; }
        public string hsHasta { get; set; }

        public string HorarioLegible => $"Desde {hsDesde} Hasta {hsHasta}";
    }
}