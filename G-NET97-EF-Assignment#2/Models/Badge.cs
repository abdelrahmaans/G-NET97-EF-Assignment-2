using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET97_EF_Assignment_2.Models
{
    internal class Badge
    {
        public int Id { get; set; }

        public int BadgeNumber { get; set; }

        public DateTime IssuedDate { get; set; }

        public BadgeTier Tier { get; set; }

        public int AttendeeId { get; set; }

        public Attendee Attendee { get; set; } = null!;
    }

    public enum BadgeTier
    {
        Standard,
        VIP
    }
}
