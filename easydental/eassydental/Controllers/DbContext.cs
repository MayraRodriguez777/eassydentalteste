using eassydental.Controllers;
using Microsoft.EntityFrameworkCore;


namespace eassydental.Controllers
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }

}
