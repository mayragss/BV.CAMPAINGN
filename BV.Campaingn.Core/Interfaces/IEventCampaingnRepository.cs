using BV.Campaingn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV.Campaingn.Domain.Interfaces
{
    public interface IEventCampaingnRepository : IBaseRepository<EventCampaingn>
    {
        Task<EventCampaingn> GetByNameAsync(string name, CancellationToken cancellationToken);
    }
}
