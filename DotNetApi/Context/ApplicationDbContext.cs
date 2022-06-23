using DotNetApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetApi.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
               
        }
        public DbSet<Post> posts{ get; set; }
    }
}
