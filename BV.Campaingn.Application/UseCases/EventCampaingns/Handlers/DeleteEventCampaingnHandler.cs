using AutoMapper;
using BV.Campaingn.Domain.Entities;
using BV.Campaingn.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV.Campaingn.Application.UseCases.EventCampaingns.Create
{
    public sealed class DeleteEventCampaingnHandler : IRequestHandler<DeleteEventCampaingnRequest, DeleteEventCampaingnResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEventCampaingnRepository _eventCampaingnRepository;
        private readonly IMapper _mapper;

        public DeleteEventCampaingnHandler(IUnitOfWork unitOfWork, IEventCampaingnRepository eventCampaingnRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _eventCampaingnRepository = eventCampaingnRepository;
            _mapper = mapper;
        }

        public async Task<DeleteEventCampaingnResponse> Handle(DeleteEventCampaingnRequest input, CancellationToken cancellationToken)
        {
            var @event = await _eventCampaingnRepository.Get(input.id, cancellationToken).ConfigureAwait(false);
            
            if (@event == null) return default;

            _eventCampaingnRepository.Delete(@event);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<DeleteEventCampaingnResponse>(@event);
        }
    }
}
