using Microsoft.EntityFrameworkCore;
namespace parte9_Guia_HttpHelper.Models
{
    public class equiposDbContext : DbContext
    {
        public equiposDbContext(DbContextOptions<equiposDbContext> options) : base(options) { }

        public DbSet<equipos> equipos { get; set; }
        public DbSet<marcas> marcas { get; set; }
    }
}
