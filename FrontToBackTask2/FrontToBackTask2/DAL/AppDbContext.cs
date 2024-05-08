using FrontToBackTask2.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontToBackTask2.DAL
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
        public DbSet<OrganicProduct> OrganicProducts { get; set; }

    }
}
