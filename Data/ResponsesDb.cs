using Microsoft.EntityFrameworkCore;
using Party.Models;

namespace Party.Data
{
    public class ResponsesDb : DbContext
    {
        public DbSet<Invited> Invited { get; set; }


        public ResponsesDb(DbContextOptions<ResponsesDb> options) : base(options)
        {

        }
    }
}
