namespace Mind_Sentinel.Model
{
    public class TherapeuticSession
    {
        public int session_id { get; set; }
        public int patient_id { get; set; }
        public DateTime date { get; set; }
        public string session_type { get; set; }
    }
}
