using Microsoft.EntityFrameworkCore;

namespace Our_Team
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<TeamMember> TeamMembers { get; set; }
    }
}