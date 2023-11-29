using Microsoft.EntityFrameworkCore;

namespace DTO.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Category entity
            modelBuilder.Entity<Category>()
                .HasKey(c => c.CId);

            modelBuilder.Entity<Category>()
                .Property(c => c.CName)
                .IsRequired();

            // Configure Location entity
            modelBuilder.Entity<Location>()
                .HasKey(l => l.LID);

            modelBuilder.Entity<Location>()
                .Property(l => l.LName)
                .IsRequired();

            // Configure Breed entity
            modelBuilder.Entity<Breed>()
                .HasKey(b => b.BId);

            modelBuilder.Entity<Breed>()
                .Property(b => b.BName)
                .IsRequired();

            modelBuilder.Entity<Breed>()
                .HasOne(b => b.category)
                .WithMany()
                .HasForeignKey(b => b.Category)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure Pet entity
            modelBuilder.Entity<Pet>()
                .HasKey(p => p.PId);

            modelBuilder.Entity<Pet>()
                .Property(p => p.PName)
                .IsRequired();

            modelBuilder.Entity<Pet>()
                .Property(p => p.PDescription)
                .IsRequired();

            modelBuilder.Entity<Pet>()
                .HasOne(p => p.category)
                .WithMany()
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Pet>()
                .HasOne(p => p.location)
                .WithMany()
                .HasForeignKey(p => p.LocationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Pet>()
                .HasOne(p => p.breed)
                .WithMany()
                .HasForeignKey(p => p.BreedId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
