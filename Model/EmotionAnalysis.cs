using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Mind_Sentinel.Model
{
    public class EmotionAnalysis
    {
        public int analysis_id { get; set; }
        [ForeignKey("therapeutic_session")]
        public int session_id { get; set; }
        public string emotion_type { get; set; }
        public int intensity_score { get; set; }
        [ForeignKey("risk_assessment")]
        public int? risk_id { get; set; }
        public TherapeuticSession therapeutic_session { get; set; }
        public RiskAssessment? risk_assessment { get; set; }
    }
}
