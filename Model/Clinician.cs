using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using System.ComponentModel.DataAnnotations;

namespace Mind_Sentinel.Model
{
    public class Clinician
    {
        [Key]
        public int clinician_id { get; set; }
        public int user_id { get; set; }
        public string specialization { get; set; }
    }
}
