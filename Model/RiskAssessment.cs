namespace Mind_Sentinel.Model;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class RiskAssessment
{
    public int risk_id { get; set; }
    [ForeignKey("emotion_analysis")]
    public int analysis_id { get; set; }
    public int risk_level { get; set; }
    public EmotionAnalysis emotion_analysis { get; set; }
}
