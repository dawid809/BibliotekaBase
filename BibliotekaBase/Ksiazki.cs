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
    
    public partial class Ksiazki
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ksiazki()
        {
            this.Wypozyczenia = new HashSet<Wypozyczenia>();
        }
    
        public int Ksiazka_ID { get; set; }
        public string Nazwa { get; set; }
        public int Ilosc_stron { get; set; }
        public int Autor_ID { get; set; }
        public int TypKsiazki_ID { get; set; }
    
        public virtual Autorzy Autorzy { get; set; }
        public virtual TypKsiazki TypKsiazki { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wypozyczenia> Wypozyczenia { get; set; }
    }
}
