using Microsoft.EntityFrameworkCore;
using CRUDAPI.Models;

namespace CRUDAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
    }
}


