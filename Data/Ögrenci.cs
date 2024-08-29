
using System.ComponentModel.DataAnnotations;



namespace efcoreApp.Data
{
    public class Ogrenci 
    {
        [Key]
        public int OgrenciId { get; set; }
        public string? OgrenciAd { get; set; }
        public string? OgrencisoyAd { get; set; }
        public string? Eposta { get; set; }
        

    }
}
