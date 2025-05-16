using Microsoft.EntityFrameworkCore;
using Simulation3.Models;

namespace Simulation3.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

    public DbSet<Course> Products { get; set; }
        public DbSet<Trainer> Categories { get; set; }
    }
}

