//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quanlikhohang
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietHDN
    {
        public int MaCT { get; set; }
        public Nullable<int> MaHD { get; set; }
        public Nullable<int> MaNL { get; set; }
        public double SoLuong { get; set; }
    
        public virtual HoaDonNhapNL HoaDonNhapNL { get; set; }
        public virtual NguyenLieu NguyenLieu { get; set; }
    }
}
