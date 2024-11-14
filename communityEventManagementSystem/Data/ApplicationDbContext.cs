using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using communityEventManagementSystem.Data.Models;

namespace communityEventManagementSystem.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Event> Events { get; set; }

        //public DbSet<Participants> Participants { get; set; }

        //public DbSet<Venues> Venues { get; set; }

       // public DbSet<Activities> Activities { get; set; }

       // public DbSet<Registrations> Registrations { get; set; }
    }
}
