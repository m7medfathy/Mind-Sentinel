namespace Mind_Sentinel.Model;

using System.ComponentModel.DataAnnotations;

public class TherapeuticSession
{
    [Key]
    public int session_id { get; set; }
    public int patient_id { get; set; }
    public DateTime date { get; set; }
    public string session_type { get; set; }
    public Clinician clinician { get; set; }
    public Patient patient { get; set; }
    public EmotionAnalysis emotion_analyses { get; set; }
}
