using System.ComponentModel.DataAnnotations.Schema;
using testNettly.web.Models;

namespace NettlyMVCWebApp.web.Data
{
    public class Appointment
    {
        public int Id { get; set; } 
        public string AppointmentName { get; set; }
        public string Description { get; set; }
        public DateTime AppointmentDate  { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        
        
        [ForeignKey("UserId")]
        public User User { get; set; }
        public int UserId {  get; set; }
        
        
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } public DateTime LastUpdated { get; set; }
        
    }
    }

