//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Otobus1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bilet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bilet()
        {
            this.Satislar = new HashSet<Satislar>();
            this.Sepet = new HashSet<Sepet>();
        }
    
        public int id { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public Nullable<int> Fiyat { get; set; }
        public Nullable<System.DateTime> Stok { get; set; }
        public Nullable<bool> Populer { get; set; }
        public string KategoriId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satislar> Satislar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sepet> Sepet { get; set; }
    }
}
