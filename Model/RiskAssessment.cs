namespace Mind_Sentinel.Model
{
    public class RiskAssessment
    {
        public int risk_id { get; set; }
        public int analysis_id { get; set; }
        public int risk_level { get; set; }
        public EmotionAnalysis emotion_analysis { get; set; }
    }
}
