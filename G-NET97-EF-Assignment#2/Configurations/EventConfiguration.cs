using G_NET97_EF_Assignment_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET97_EF_Assignment_2.Configurations
{
    internal class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasOne(e => e.Organizer)
                   .WithMany(o => o.Events)
                   .HasForeignKey(e => e.OrganizerId);
        }
    }
}
