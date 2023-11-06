using BV.Campaingn.Domain.Entities;
using BV.Campaingn.Domain.Interfaces;
using BV.Campaingn.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV.Campaingn.Infrastructure.Repositories
{
    public class EventCampaingnRepository : BaseRepository<EventCampaingn>, IEventCampaingnRepository
    {
        public EventCampaingnRepository(AppDbContext context): base(context) { }

        public async Task<EventCampaingn> GetByNameAsync(string name, CancellationToken cancellationToken)
        {
            return await Context.EventCampaings.FirstOrDefaultAsync(x => x.Name == name, cancellationToken);
        }
    }
}
