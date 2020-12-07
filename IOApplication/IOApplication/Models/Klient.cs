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
    using System.ComponentModel.DataAnnotations;

    public partial class Klient
    {
        [Display(Name = "ID Klienta")]
        public int IdKlienta { get; set; }
      
        [Display(Name = "Imi�")]

        public string Imie { get; set; }
        [Display(Name = "Nazwisko")]
        public string Nazwisko { get; set; }
        [Display(Name = "Adres")]
        public string Adres { get; set; }
        [Display(Name = "Miasto")]
        public string Miasto { get; set; }
        [Display(Name = "Kod Pocztowy")]
        public string KodPocztowy { get; set; }
        [Display(Name = "Kraj")]
        public string Kraj { get; set; }
        [Display(Name = "Telefon")]
        public string Telefon { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }   
        [Display(Name = "Data do�adowania")]
        public System.DateTime DataDoladowania { get; set; }
        [Display(Name = "Karnet")]
        public int Karnet { get; set; }
        [Display(Name = "Data wyga�ni�cia")]
        public Nullable<System.DateTime> DataWygasniecia { get; set; }
        [Display(Name = "Zaj�cia")]
        public int IdZajecia { get; set; }
        [Display(Name = "Login")]
        public string Login { get; set; }
        [Display(Name = "Has�o")]
        public string Haslo { get; set; }
    
        public virtual Zajecia Zajecia { get; set; }
    }
}
