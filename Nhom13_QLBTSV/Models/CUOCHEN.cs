//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLBTSV.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CUOCHEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUOCHEN()
        {
            this.SINHVIENCUOCHENs = new HashSet<SINHVIENCUOCHEN>();
        }
    
        public int macuochen { get; set; }
        public Nullable<System.DateTime> thoigianbatdau { get; set; }
        public Nullable<System.DateTime> thoigianketthuc { get; set; }
        public string ghichu { get; set; }
        public string malop { get; set; }
        public string magiaovien { get; set; }
        public int tinhtrang { get; set; }
        public string diadiem { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SINHVIENCUOCHEN> SINHVIENCUOCHENs { get; set; }
    }
}
