namespace Mind_Sentinel.Model;

using System.ComponentModel.DataAnnotations;

public class JournalEntry
{
    [Key]
    public int entry_id { get; set; }
    public int patient_id { get; set; }
    public string text { get; set; }
    public DateTime date { get; set; }
    public Patient patient { get; set; }
}
