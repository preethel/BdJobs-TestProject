using Microsoft.EntityFrameworkCore;
using TestProject.Models;

namespace TestProject.DataContext
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Book> Books{ get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                modelBuilder.Entity<BookType>().HasData(
                new BookType { Id=1, Title = "sci-fi" },
                new BookType { Id=2, Title = "drama" },
                new BookType {  Id=3, Title = "novel" }

                );
            modelBuilder.Entity<Book>()
       .HasKey(b => b.Id);

            modelBuilder.Entity<Book>()
                .Property(b => b.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();
        }
    }
}
