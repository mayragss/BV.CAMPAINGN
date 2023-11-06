using BV.Campaingn.Domain.Entities;
using MediatR; 

namespace BV.Campaingn.Application.UseCases.EventCampaingns.Create;

public sealed record CreateEventCampaingnRequest(
    string Name, 
    string Description,
    decimal Budget,
    string Tags,
    string ImageUrl
    ) :
                                  IRequest<CreateEventCampaingnResponse>;
