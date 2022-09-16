using CRM_System.Models;
using Microsoft.EntityFrameworkCore;

namespace CRM_System.Data
{
    public class PostDatabase : DbContext
    {
        public DbSet<Message> Messages { get; set; }
        public PostDatabase()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql();
        }
    }
}
