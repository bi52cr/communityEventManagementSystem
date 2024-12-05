using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using communityEventManagementSystem.Data.Models;

namespace communityEventManagementSystem.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Event> Events { get; set; }

        //public DbSet<Participant> Participants { get; set; }

        //public DbSet<Venue> Venues { get; set; }

        public DbSet<Activity> Activities { get; set; }

       // public DbSet<Registration> Registrations { get; set; }
    }
}
