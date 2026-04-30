using Microsoft.EntityFrameworkCore;
using Mind_Sentinel.Model;

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

            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            var constr = configuration.GetSection("constr").Value;

            optionsBuilder.UseSqlServer(constr);

        }

        
    }
}
