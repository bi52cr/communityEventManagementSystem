using System.ComponentModel.DataAnnotations;

namespace communityEventManagementSystem.Data.Models
{
    public class Participant
    {
        [Key]
        public uint Id { get; set; }

        public string Name { get; set; }

        public EmailAddressAttribute Email { get; set; }

        public PhoneAttribute PhoneNumber { get; set; }
    }
}
