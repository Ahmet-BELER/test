using Microsoft.EntityFrameworkCore;

namespace efcoreApp.Data 
{
    public class DataContext : DbContext 
    {
        public DbSet<Kurs> Kurslar { get; set; } 
        
        public DbSet<Ogrenci> Ogreciler    { get; set; }

        public DbSet<KursKayit> KursKayitlari { get; set; } 




    }

    



}