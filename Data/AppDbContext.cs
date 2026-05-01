using Microsoft.EntityFrameworkCore;
using Mind_Sentinel.Model;
using Mind_Sentinel.ModelsConfiguration;

namespace Mind_Sentinel.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Clinician> Clinicans { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<TherapeuticSession> TherapeuticSessions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<EmotionAnalysis> EmotionAnalyses { get; set; }
        public DbSet<JournalEntry> JournalEntries { get; set; }
        public DbSet<ProgressReport> ProgressReports { get; set; }
        public DbSet<RiskAssessment> RiskAssessments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var constr = configuration
                .GetSection("constr")
                .Value;

            optionsBuilder.UseSqlServer(constr);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TherapeuticSession>().HasOne(e => e.patient).
                WithMany(e => e.therapeutic_sessions).
                HasForeignKey(e => e.session_id).IsRequired();

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfiguration).Assembly);

        }

    }
}
