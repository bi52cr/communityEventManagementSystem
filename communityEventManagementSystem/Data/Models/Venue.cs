using System.ComponentModel.DataAnnotations;

namespace communityEventManagementSystem.Data.Models
{
    public class Venue
    {
        public uint Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public uint Capacity { get; set; }
    }
}
