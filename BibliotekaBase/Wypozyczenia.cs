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
    using System.Collections.ObjectModel;
    
    public partial class Wypozyczenia
    {
        public int Wypozyczenia_ID { get; set; }
        public int Student_ID { get; set; }
        public int Ksiazka_ID { get; set; }
        public System.DateTime Data_Wypozyczenia { get; set; }
        public Nullable<System.DateTime> Data_Oddania { get; set; }
    
        public virtual Ksiazki Ksiazki { get; set; }
        public virtual Studenci Studenci { get; set; }
    }
}
