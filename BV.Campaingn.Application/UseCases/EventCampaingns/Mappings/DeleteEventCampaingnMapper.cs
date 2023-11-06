using AutoMapper; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BV.Campaingn.Domain.Entities;

namespace BV.Campaingn.Application.UseCases.EventCampaingns.Create;

public sealed class DeleteEventCampaingnMapper : Profile
{
    public DeleteEventCampaingnMapper()
    {
        CreateMap<DeleteEventCampaingnRequest, EventCampaingn > ();
        CreateMap<EventCampaingn, DeleteEventCampaingnResponse>();
    }
}
