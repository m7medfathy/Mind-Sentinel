using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mind_Sentinel.Model;

namespace Mind_Sentinel.ModelsConfiguration
{
    public partial class EmotionAnalysisConfiguration : IEntityTypeConfiguration<EmotionAnalysis>
    {
        public void Configure(EntityTypeBuilder<EmotionAnalysis> builder)
        {
            builder.HasKey(e => e.analysis_id);

            builder.Property(e => e.analysis_id)
                .ValueGeneratedNever();

        }
    }
}