using Broadcaster.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Broadcaster.Infrastructure.Mapping
{
    public class ChannelMapping : IEntityTypeConfiguration<Channel>
    {
        public void Configure(EntityTypeBuilder<Channel> builder)
        {
            //builder.ToTable("Channel");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ChannelName).IsRequired();
        }
    }
}
