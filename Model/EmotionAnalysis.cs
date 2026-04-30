namespace Mind_Sentinel.Model
{
    public class EmotionAnalysis
    {
        public int analysis_id { get; set; }
        public int session_id { get; set; }
        public string emotion_type { get; set; }
        public int intensity_score { get; set; }
    }
}
