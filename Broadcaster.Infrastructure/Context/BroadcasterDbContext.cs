using Broadcaster.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadcaster.Infrastructure.Context
{
    public class BroadcasterDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BroadcasterDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Message> Messages{ get; set; }
        public DbSet<Channel> Channels { get; set; }
    }
}
