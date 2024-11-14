using System.ComponentModel.DataAnnotations;

namespace communityEventManagementSystem.Data.Models
{
    public class Activity
    {
        public uint Id { get; set; }

        public string Name { get; set; }

        public List<Event> Events { get; } = [];
    }
}
