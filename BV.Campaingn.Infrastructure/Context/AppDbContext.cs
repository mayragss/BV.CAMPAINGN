using BV.Campaingn.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV.Campaingn.Infrastructure.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        public DbSet<EventCampaingn> EventCampaings { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<EventCampaingn>().HasKey(c => c.Id);
            mb.Entity<EventCampaingn>().Property(c => c.Name).HasMaxLength(50).IsRequired();
            mb.Entity<EventCampaingn>().Property(c => c.StartDate);
            mb.Entity<EventCampaingn>().Property(c => c.EndDate);
            mb.Entity<EventCampaingn>().Property(c => c.Description);
            mb.Entity<EventCampaingn>().Property(c => c.Budget).HasPrecision(18,4);
            mb.Entity<EventCampaingn>().Property(c => c.IsActive);
            mb.Entity<EventCampaingn>().Property(c => c.Tags).HasColumnType("text");
            mb.Entity<EventCampaingn>().Property(c => c.ImageUrl); 
        }
    }
}
