using Microsoft.EntityFrameworkCore;

namespace testNettly.web.Controllers
{
    
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Feedback> Feedbacks { get; set; }
    }

    public class Feedback
    {
        internal string Username;
        internal int Id;
        internal string Comment;
        internal object Score;
    }
}