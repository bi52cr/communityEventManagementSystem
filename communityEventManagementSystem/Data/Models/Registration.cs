using System.ComponentModel.DataAnnotations;

namespace communityEventManagementSystem.Data.Models
{
    public class Registration
    {
        public uint Id { get; set; }

        public uint EventID { get; set; }

        public uint ParticipantID { get; set; }

        public DateTime ReigistrationDate { get; set; }

        public string Status {  get; set; }

    }
}
