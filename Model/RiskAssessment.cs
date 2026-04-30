namespace Mind_Sentinel.Model;

using System.ComponentModel.DataAnnotations;

public class RiskAssessment
{
    [Key]
    public int risk_id { get; set; }
    public int analysis_id { get; set; }
    public int risk_level { get; set; }
    public EmotionAnalysis emotion_analysis { get; set; }
}
