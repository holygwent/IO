//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IOApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trener
    {
        public int IdTrener { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Adres { get; set; }
        public string Miasto { get; set; }
        public string KodPocztowy { get; set; }
        public string Kraj { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Pesel { get; set; }
        public System.DateTime DataUrodzenia { get; set; }
        public System.DateTime DataZatrudnienia { get; set; }
        public int IdZajecia { get; set; }
        public string NrBankowy { get; set; }
    
        public virtual Zajecia Zajecia { get; set; }
    }
}
