using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using NettlyMVCWebApp.web.Data;

namespace testNettly.web.Data
{
    public class ApplicationDbContext : IdentityDbContext<UserProfile>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet <Appointment> Appointments { get; set; }
        public DbSet <Feedback> Feedbacks { get; set; }
        
    }

}
