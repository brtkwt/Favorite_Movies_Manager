using Favorite_Movies_Manager.Models;
using Microsoft.EntityFrameworkCore;

namespace Favorite_Movies_Manager.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {

        }

        public DbSet<Movie> Movies {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().Property(p => p.Rating).HasColumnType("decimal(18,2)");
        }
    }
}
