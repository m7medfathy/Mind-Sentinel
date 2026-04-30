namespace Mind_Sentinel.Model
{
    public class Patient
    {
        public int patient_id { get; set; }
        public int user_id { get; set; }
        public DateTime date_of_birth { get; set; }
        public string mental_state { get; set; }
        public User user { get; set; }
        public List<JournalEntry> journal_entries { get; set; }
        public List<ProgressReport> progress_reports { get; set; }
        public List<TherapeuticSession> therapeutic_sessions { get; set; }

    }
}
