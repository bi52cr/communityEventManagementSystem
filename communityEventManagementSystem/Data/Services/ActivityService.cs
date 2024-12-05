using Microsoft.EntityFrameworkCore;
using communityEventManagementSystem.Data;
using communityEventManagementSystem.Data.Models;

namespace communityEventManagementSystem.Data.Services
{
    public class ActivityService  
    {
        IDbContextFactory<ApplicationDbContext> contextFactory;

        public ActivityService(IDbContextFactory<ApplicationDbContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public void Add(Activity activities)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                context.Activities.Add(activities);
                context.SaveChanges();
            }
        }
    }
}
