
using BasicMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicMVC.DataLayer{
    public class BasicDBContext : DbContext{

        public DbSet<Message> messages { get; set; }

        public BasicDBContext(DbContextOptions<BasicDBContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Message>().HasData(
                new Message {MessageID = 1, MessageText = "MESSAGE ONE"},
                new Message {MessageID = 2, MessageText = "MESSAGE TWO"}
            );
        }

    }
}