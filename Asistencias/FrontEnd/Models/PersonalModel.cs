using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontEnd.Models
{
    public class PersonalModel
    {
        public Guid viewId { get; set; }
        public string viewNombre { get; set; }
        public string viewApellido { get; set; }
        public DateTime viewFechaNac { get; set; }
        public byte viewFoto { get; set; }
        public string viewDomicilio { get; set; }
        public string viewEmail { get; set; }
        public string viewDni { get; set; }
        public Guid viewIdHorario { get; set; }
       
    }
}