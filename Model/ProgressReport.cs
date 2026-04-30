namespace Mind_Sentinel.Model;

using System.ComponentModel.DataAnnotations;

public class ProgressReport
{
    [Key]
    public int report_id { get; set; }
    public int patient_id { get; set; }
    public string progress_summary { get; set; }
}
