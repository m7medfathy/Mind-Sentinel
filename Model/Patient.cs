namespace Mind_Sentinel.Model;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Patient
{
    public int report_id { get; set; }
    [ForeignKey("user")]
    public int user_id { get; set; }
    public DateTime date_of_birth { get; set; }
    public string mental_state { get; set; }
    public User user { get; set; }
    public List<JournalEntry>? journal_entries { get; set; }
    public List<ProgressReport>? progress_reports { get; set; }
    public List<TherapeuticSession> therapeutic_sessions { get; set; }

}
