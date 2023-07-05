using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MoodTracker.Models
{
    public class MoodTrackerDbContext : IdentityDbContext<ApplicationUser>
    {
        public MoodTrackerDbContext(DbContextOptions<MoodTrackerDbContext> options)
       : base(options)
        {
        }
        public DbSet<Medication> Medication { get; set; }
        public DbSet<PsychoticSymptom> PsychoticSymptoms { get; set; }
        public DbSet<SleepHour> SleepHour { get; set; }
        public DbSet<TalkTherapy> TalkTherapy { get; set; }
        public DbSet<Note> Note { get; set; }
        public DbSet<CustomScaleTrackingPoint> customScaleTrackingPoint { get; set; }
        public DbSet<CustomBoolTrackingPoint> customBoolTrackingPonint { get; set; }
        public DbSet<ExtremeAnexietyMood> extremeAnexietyMood{ get; set; }
        public DbSet<ExtremeDepressedMood> extremeDepressedMood { get; set; }
        public DbSet<ExtremeIrritableMood> extremeIrritableMood { get; set; }
        public DbSet<ExtremeElevatedMood> extremeElevatedMood { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Medication>()
                .HasOne(m => m.User)
                .WithMany()
                .HasForeignKey(m => m.UserId)
                .IsRequired();

            builder.Entity<PsychoticSymptom>()
                .HasOne(p => p.User)
                .WithMany()
                .HasForeignKey(p => p.UserId)
                .IsRequired();

            builder.Entity<SleepHour>()
                .HasOne(s => s.User)
                .WithMany()
                .HasForeignKey(s => s.UserId)
                .IsRequired();

            builder.Entity<TalkTherapy>()
                .HasOne(t => t.User)
                .WithMany()
                .HasForeignKey(t => t.UserId)
                .IsRequired();

            builder.Entity<Note>()
                .HasOne(n => n.User)
                .WithMany()
                .HasForeignKey(n => n.UserId)
                .IsRequired();

            builder.Entity<CustomScaleTrackingPoint>()
                .HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserId)
                .IsRequired();

            builder.Entity<CustomBoolTrackingPoint>()
                .HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserId)
                .IsRequired();

            builder.Entity<ExtremeAnexietyMood>()
                .HasOne(e => e.User)
                .WithMany()
                .HasForeignKey(e => e.UserId)
                .IsRequired();

            builder.Entity<ExtremeDepressedMood>()
                .HasOne(e => e.User)
                .WithMany()
                .HasForeignKey(e => e.UserId)
                .IsRequired();

            builder.Entity<ExtremeIrritableMood>()
                .HasOne(e => e.User)
                .WithMany()
                .HasForeignKey(e => e.UserId)
                .IsRequired();

            builder.Entity<ExtremeElevatedMood>()
                .HasOne(e => e.User)
                .WithMany()
                .HasForeignKey(e => e.UserId)
                .IsRequired();
        }


    }
}
