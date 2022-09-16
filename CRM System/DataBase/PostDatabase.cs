using CRM_System.Models;
using Microsoft.EntityFrameworkCore;

namespace CRM_System.DataBase
{
    public class PostDatabase : DbContext
    {
        public PostDatabase(DbContextOptions<PostDatabase> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Message> MessageData { get; set; }
    }
}
