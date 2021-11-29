using System;
using System.ComponentModel.DataAnnotations;

namespace latihan1.Models
{
    public class Mahasiswa
    {
        [Required(ErrorMessage = "Nama Wajib diisi")]
        public string Nama{get;set;}
        public string Kelas{get;set;}
        [Required(ErrorMessage = "Tempat Lahir Wajib diisi")]
        [RegularExpression("^[a-zA-Z]*$",
        ErrorMessage = "Tempat Lahir Hanya Huruf")]
        public string TempatLahir {get;set;}
        [DataType(DataType.Date)]
        public DateTime TglLahir{get;set;}
        [Range(100,100,ErrorMessage="Tinggi Badan Antara 100-800")]
        public int TinggiBadan{get;set;}
        [RegularExpression("^[0-9]+$")]
        public string Hp{get;set;} 
    }
}