//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BibliotekaBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Studenci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Studenci()
        {
            this.Wypozyczenia = new HashSet<Wypozyczenia>();
        }
    
        public int Student_ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public System.DateTime DataUrodzenia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wypozyczenia> Wypozyczenia { get; set; }
    }
}
