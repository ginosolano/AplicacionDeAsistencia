using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontEnd.Models
{
    public class RegistroModel
    {
        public Guid Id { get; set; }
        public Guid IdPersonal { get; set; }
        public DateTime fechahora { get; set; }
        public Byte[] foto { get; set; }
        public string movimiento{ get; set; }
        public Guid IdHorario { get; set; }

    }
}
