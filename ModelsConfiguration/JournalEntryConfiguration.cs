using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mind_Sentinel.Model;

namespace Mind_Sentinel.ModelsConfiguration
{
    public partial class EmotionAnalysisConfiguration
    {
        public class JournalEntryConfiguration : IEntityTypeConfiguration<JournalEntry>
        {
            public void Configure(EntityTypeBuilder<JournalEntry> builder)
            {
                builder.HasKey(e => e.entry_id);

                builder.Property(e => e.entry_id)
                    .ValueGeneratedNever();
            }
        }
    }
}