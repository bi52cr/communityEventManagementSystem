using Microsoft.EntityFrameworkCore;
using communityEventManagementSystem.Data;
using communityEventManagementSystem.Data.Models;

namespace communityEventManagementSystem.Data.Services
{
    public class EventService
    {
        IDbContextFactory<ApplicationDbContext> contextFactory;

        public EventService(IDbContextFactory<ApplicationDbContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public void Add(Event events)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                context.Events.Add(events);
                context.SaveChanges();
            }
        }
    }
}
