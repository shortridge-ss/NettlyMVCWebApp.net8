using System.ComponentModel.DataAnnotations.Schema;
using testNettly.web.Models;

namespace NettlyMVCWebApp.web.Data
{
    public class Feedback
    {
        public int Id { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        public int UserId { get; set; }
        

        public string Comments { get; set; }
        public string? Rating { get; set; }
            public DateTime DateSubmitted { get; set; } = DateTime.Now;
            
    }
}
