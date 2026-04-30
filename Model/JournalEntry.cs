namespace Mind_Sentinel.Model
{
    public class JournalEntry
    {
        public int entry_id { get; set; }
        public int patient_id { get; set; }
        public string text { get; set; }
        public DateTime date { get; set; }
    }
}
