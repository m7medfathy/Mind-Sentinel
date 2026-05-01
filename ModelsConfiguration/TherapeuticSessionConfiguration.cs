using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mind_Sentinel.Model;

namespace Mind_Sentinel.ModelsConfiguration
{
    public partial class EmotionAnalysisConfiguration
    {
        public class TherapeuticSessionConfiguration : IEntityTypeConfiguration<TherapeuticSession>
        {
            public void Configure(EntityTypeBuilder<TherapeuticSession> builder)
            {
                builder.HasKey(e => e.session_id);

                builder.Property(e => e.session_id)
                    .ValueGeneratedNever();
            }
        }
    }
}