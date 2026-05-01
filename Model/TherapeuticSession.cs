namespace Mind_Sentinel.Model;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class TherapeuticSession
{
    public int session_id { get; set; }
    public DateTime date { get; set; }
    [ForeignKey ("emotion_analyses")]
    public int analysis_id { get; set; }
    public string session_type { get; set; }
    [ForeignKey("clinician")]
    public int clinician_id { get; set; }
    public Clinician clinician { get; set; }
    public Patient patient { get; set; }
    public EmotionAnalysis emotion_analyses { get; set; }
}
