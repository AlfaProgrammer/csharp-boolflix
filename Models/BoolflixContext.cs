using Microsoft.EntityFrameworkCore;

namespace csharp_boolflix.Models
{
    public class BoolflixContext : DbContext
    {
        public DbSet<VideoContent> VideoContents { get; set; }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=boolflix;Integrated Security=True");
        }
    }

}