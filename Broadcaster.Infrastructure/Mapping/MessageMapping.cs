using Broadcaster.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadcaster.Infrastructure.Mapping
{
    public class MessageMapping : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            //builder.
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PublisherName).IsRequired();
            builder.Property(x => x.Text).IsRequired();
        }
    }
}
