using Microsoft.EntityFrameworkCore;
using Party.Models;

namespace Party.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Invited> Invited { get; set; }


        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
    }
}
