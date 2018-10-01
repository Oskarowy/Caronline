using Caronline.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class CaronlineDbContext : DbContext
    {
        public CaronlineDbContext(DbContextOptions<CaronlineDbContext> options)
            : base(options)
        {
        }
            public DbSet<Make> Makes { get; set; } 
    }
}