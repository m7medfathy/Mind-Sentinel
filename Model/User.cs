namespace Mind_Sentinel.Model;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    public int user_id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public Clinician? clinician { get; set; }
    public Patient? patient { get; set; }
}
