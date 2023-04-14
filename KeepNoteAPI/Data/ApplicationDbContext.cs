using Microsoft.EntityFrameworkCore;

namespace KeepNoteAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Note> Notes => Set<Note>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>().HasData(
              new Note
              {
                  Id = 1,
                  Title = "First Note",
                  Content = "This is the content of the first note."
              },
              new Note
              {
                  Id = 2,
                  Title = "Second Note",
                  Content = "This is the content of the second note."
              },
              new Note
              {
                  Id = 3,
                  Title = "Third Note",
                  Content = null
              },
              new Note
              {
                  Id = 4,
                  Title = "Fourth Note",
                  Content = "This is the content of the fourth note."
              }
              );
        }
    }
}
