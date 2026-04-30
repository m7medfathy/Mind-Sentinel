namespace Mind_Sentinel.Model;

using System.ComponentModel.DataAnnotations;

public class Patient
{
    [Key]
    public int patient_id { get; set; }
    public int user_id { get; set; }
    public DateTime date_of_birth { get; set; }
    public string mental_state { get; set; }
}
