//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeknikServis
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_UrunHareket
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<int> Adet { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
    
        public virtual Tbl_Cari Tbl_Cari { get; set; }
        public virtual Tbl_Personel Tbl_Personel { get; set; }
        public virtual Tbl_Urun Tbl_Urun { get; set; }
    }
}
