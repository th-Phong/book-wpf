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
    
    public partial class CHITIETSACH
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public decimal DonGiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public int LanTaiBan { get; set; }
        public short SoTrang { get; set; }
        public string LoaiBia { get; set; }
        public Nullable<System.DateTime> NgayXuatBan { get; set; }
    
        public virtual SACH SACH { get; set; }
    }
}