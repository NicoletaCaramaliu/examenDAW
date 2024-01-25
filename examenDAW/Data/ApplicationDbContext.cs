
using examenDAW.Models;
using examenDAW.Models.Eveniment;
using examenDAW.Models.Participant;
using examenDAW.Models.ParticipantiEvenimente;
using Microsoft.EntityFrameworkCore;

namespace examenDAW.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Eveniment> Evenimente { get; set; }
        public DbSet<Participant> Participanti { get; set; }
        public DbSet<ParticipantiEvenimente> ParticipantiEvenimente { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParticipantiEvenimente>()
                .HasKey(bc => new { bc.ParticipantId, bc.EvenimentId });

            //many to many
            modelBuilder.Entity<ParticipantiEvenimente>()
                .HasOne(bc => bc.Participant)
                .WithMany(b => b.ParticipantiEvenimente)
                .HasForeignKey(bc => bc.ParticipantId);

            modelBuilder.Entity<ParticipantiEvenimente>()
                .HasOne(bc => bc.Eveniment)
                .WithMany(c => c.ParticipantiEvenimente)
                .HasForeignKey(bc => bc.EvenimentId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
