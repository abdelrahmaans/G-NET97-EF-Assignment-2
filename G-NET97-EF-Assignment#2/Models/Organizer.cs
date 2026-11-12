using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET97_EF_Assignment_2.Models
{
    [Table("EventOrganizers")]
    internal class Organizer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(150)]
        public string? CompanyName { get; set; }

        public bool IsVerified { get; set; }

        public OrganizerProfile Profile { get; set; } = null!;

        public ICollection<Event> Events { get; set; } = new List<Event>();
    }
}
