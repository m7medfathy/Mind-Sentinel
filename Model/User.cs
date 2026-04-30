namespace Mind_Sentinel.Model
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public Clinician clinician { get; set; }
        public Patient patient { get; set; }
    }
}
