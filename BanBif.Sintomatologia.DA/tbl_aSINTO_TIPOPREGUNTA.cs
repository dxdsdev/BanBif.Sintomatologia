//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BanBif.Sintomatologia.DA
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_aSINTO_TIPOPREGUNTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_aSINTO_TIPOPREGUNTA()
        {
            this.tbl_aSINTO_PREGUNTA = new HashSet<tbl_aSINTO_PREGUNTA>();
        }
    
        public int CODIGOTIPOPREGUNTA { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<int> ESTADO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_aSINTO_PREGUNTA> tbl_aSINTO_PREGUNTA { get; set; }
    }
}