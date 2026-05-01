using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mind_Sentinel.Model;

namespace Mind_Sentinel.ModelsConfiguration
{
    public partial class EmotionAnalysisConfiguration
    {
        public class PatientConfiguration : IEntityTypeConfiguration<Patient>
        {
            public void Configure(EntityTypeBuilder<Patient> builder)
            {
                builder.HasKey(e => e.report_id);

                builder.Property(e => e.report_id)
                    .ValueGeneratedNever();
            }
        }
    }
}