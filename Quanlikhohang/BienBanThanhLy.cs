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
    
    public partial class BienBanThanhLy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BienBanThanhLy()
        {
            this.ChiTietBBTLs = new HashSet<ChiTietBBTL>();
        }
    
        public int MaBB { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public Nullable<int> MaNV { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietBBTL> ChiTietBBTLs { get; set; }
    }
}
