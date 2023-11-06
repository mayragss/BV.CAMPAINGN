using BV.Campaingn.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV.Campaingn.Application.UseCases.EventCampaingns.Create
{
    public sealed record DeleteEventCampaingnRequest(int id) :
                                      IRequest<DeleteEventCampaingnResponse>;
}
