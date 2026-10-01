using Microsoft.EntityFrameworkCore;
using NdaLesson12_demo.Models;
namespace NdaLesson12_demo.Entities
{
    public class NdaAppDbContext : DbContext
    {
        public NdaAppDbContext(DbContextOptions<NdaAppDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
