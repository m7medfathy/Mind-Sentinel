using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mind_Sentinel.Model;

namespace Mind_Sentinel.ModelsConfiguration
{
    public partial class EmotionAnalysisConfiguration
    {
        public class RiskAssessmentConfiguration : IEntityTypeConfiguration<RiskAssessment>
        {
            public void Configure(EntityTypeBuilder<RiskAssessment> builder)
            {
                builder.HasKey(e => e.risk_id);

                builder.Property(e => e.risk_id)
                    .ValueGeneratedNever();
            }
        }
    }
}