//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QL_SACH.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHIEUNHAPSACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUNHAPSACH()
        {
            this.CHITIETPHIEUNHAP = new HashSet<CHITIETPHIEUNHAP>();
        }
    
        public string SoPNS { get; set; }
        public string MaNV { get; set; }
        public Nullable<System.DateTime> NgayNhap { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEUNHAP> CHITIETPHIEUNHAP { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}