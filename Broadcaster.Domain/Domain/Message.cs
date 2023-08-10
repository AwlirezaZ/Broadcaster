using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadcaster.Domain.Domain
{
    public class Message
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public string PublisherName { get; set; }
        public long ChannelId { get; set; }
    }
}
