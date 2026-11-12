using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET97_EF_Assignment_2.Models
{
    internal class OrganizerProfile
    {
        public int Id { get; set; }

        public string Biography { get; set; } = string.Empty;

        public string? Website { get; set; }

        public string? Logo { get; set; }

        public int OrganizerId { get; set; }

        public Organizer Organizer { get; set; } = null!;
    }
}
