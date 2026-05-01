using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mind_Sentinel.Model;

namespace Mind_Sentinel.ModelsConfiguration
{
    public partial class EmotionAnalysisConfiguration
    {
        public class ClinicianConfiguration : IEntityTypeConfiguration<Clinician>
        {
            public void Configure(EntityTypeBuilder<Clinician> builder)
            {
                builder.HasKey(e => e.clinician_id);

                builder.Property(e => e.clinician_id)
                    .ValueGeneratedNever();
            }
        }
    }
}