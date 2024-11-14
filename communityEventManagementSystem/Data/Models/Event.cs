using System.ComponentModel.DataAnnotations;

namespace communityEventManagementSystem.Data.Models
{
    public class Event
    {
        [Key]
        public  uint Id { get; set; }

        public string Name { get; set; }

        public DateTime DateTime { get; set; }

        public string Description { get; set; }

        public List<Activity> Activities { get; } = [];
    }
}
