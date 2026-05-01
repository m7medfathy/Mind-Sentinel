namespace Mind_Sentinel.Model;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ProgressReport
{
    public int report_id { get; set; }
    [ForeignKey("patient")]
    public int patient_id { get; set; }
    public string progress_summary { get; set; }
    public Patient patient { get; set; }
}
