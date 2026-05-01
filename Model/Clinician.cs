using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mind_Sentinel.Model
{
    public class Clinician
    {
        public int clinician_id { get; set; }
        public string specialization { get; set; }
        [ForeignKey("user")]
        public int user_id { get; set; }
        public User user { get; set; }
        public List<TherapeuticSession>? therapeutic_sessions { get; set; }
    }
}
