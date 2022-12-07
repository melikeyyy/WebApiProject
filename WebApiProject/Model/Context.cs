using Microsoft.EntityFrameworkCore;

namespace WebApiProject.Model
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-IIEMKIB; Database= ETicaretDemoDb ; Integrated Security = true");
        }

        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Sepet> Sepetim { get; set; }
    }
}
