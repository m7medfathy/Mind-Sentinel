namespace Mind_Sentinel.Model;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class JournalEntry
{
    public int entry_id { get; set; }
    [ForeignKey("patient")]
    public int patient_id { get; set; }
    public string text { get; set; }
    public DateTime date { get; set; }
    public Patient patient { get; set; }
}
