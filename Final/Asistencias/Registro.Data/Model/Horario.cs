//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Registro.Data.Model
{
    using System;
    using System.Collections.Generic;

    public partial class Horario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Horario()
        {
            this.Personals = new HashSet<Personal>();
        }

        public System.Guid Id { get; set; }
        public int hsEntrada { get; set; }
        public int minEntrada { get; set; }
        public int hsSalida { get; set; }
        public int minSalida { get; set; }
        

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personal> Personals { get; set; }
    }
}
