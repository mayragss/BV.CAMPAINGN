using AutoMapper;
using BV.Campaingn.Domain.Entities;
using BV.Campaingn.Domain.Interfaces;
using MediatR;

namespace BV.Campaingn.Application.UseCases.EventCampaingns.Create
{
    public sealed class GetEventsCampaingnHandler : IRequestHandler<GetEventsCampaingnRequest, List<GetEventsCampaingnResponse>>
    { 
        private readonly IEventCampaingnRepository _eventCampaingnRepository;
        private readonly IMapper _mapper;

        public GetEventsCampaingnHandler(IEventCampaingnRepository eventCampaingnRepository, IMapper mapper)
        { 
            _eventCampaingnRepository = eventCampaingnRepository;
            _mapper = mapper;
        }

        public async Task<List<GetEventsCampaingnResponse>> Handle(GetEventsCampaingnRequest request, CancellationToken cancellationToken)
        {
            var campaingns = await _eventCampaingnRepository.GetAll(cancellationToken); ; 

            return _mapper.Map<List<GetEventsCampaingnResponse>>(campaingns);
        }
    }
}
