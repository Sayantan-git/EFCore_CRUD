using Microsoft.EntityFrameworkCore;
using WebApplication1;

namespace EFCore_CRUD.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { } //Constuctor

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
