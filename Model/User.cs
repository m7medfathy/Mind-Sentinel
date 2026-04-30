namespace Mind_Sentinel.Model;

using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public int ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
}
