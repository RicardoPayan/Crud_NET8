using Microsoft.EntityFrameworkCore;
using crud_net_8_mvc.Models;

namespace crud_net_8_mvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
            
        }

        //Agregar los modelos aqui (Cada modelo corresponder a una tabla en la DB)
        public DbSet<Contacto> Contacto { get; set; }
    }
}
