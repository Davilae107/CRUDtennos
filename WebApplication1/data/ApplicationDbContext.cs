using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entity;

namespace WebApplication1.data
{
  
        public class ApplicationDbContext : DbContext
        {
            public DbSet<Producto> Productos { get; set; }

            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        }

    }

