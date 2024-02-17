using Microsoft.EntityFrameworkCore;
using Postit_webapp.Models;
using PostitWebAPI.Data.Map;

namespace PostitWebAPI.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Postit> Postits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PostitMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
