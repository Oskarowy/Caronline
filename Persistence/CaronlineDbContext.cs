using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class CaronlineDbContext : DbContext
    {
        public CaronlineDbContext(DbContextOptions<CaronlineDbContext> options)
            : base(options)
        {
             
        }
    }
}