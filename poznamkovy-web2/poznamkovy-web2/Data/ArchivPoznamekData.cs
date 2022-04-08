using Microsoft.EntityFrameworkCore;

namespace poznamkovy_web2.Data
{
    public class ArchivPoznamekData : DbContext
    {
        public DbSet<Poznamka> Poznamky { get; set; }
        public DbSet<Uzivatel> Uzivatele { get; set; }

        public ArchivPoznamekData(DbContextOptions<ArchivPoznamekData> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Poznamka>()
                .HasOne(u => u.Autor)
                .WithMany(a => a.Poznamky);
        }

    }
}
