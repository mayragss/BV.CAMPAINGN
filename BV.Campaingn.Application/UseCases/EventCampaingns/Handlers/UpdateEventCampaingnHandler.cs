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
    public sealed class UpdateEventCampaingnHandler : IRequestHandler<UpdateEventCampaingnRequest, UpdateEventCampaingnResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEventCampaingnRepository _eventCampaingnRepository;
        private readonly IMapper _mapper;

        public UpdateEventCampaingnHandler(IUnitOfWork unitOfWork, IEventCampaingnRepository eventCampaingnRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _eventCampaingnRepository = eventCampaingnRepository;
            _mapper = mapper;
        }

        public async Task<UpdateEventCampaingnResponse> Handle(UpdateEventCampaingnRequest input, CancellationToken cancellationToken)
        {
            var campaingn = await _eventCampaingnRepository.Get(input.request.Id, cancellationToken).ConfigureAwait(false);
            
            if (campaingn == null) return default;
              
            campaingn.Name = input.request.Name;
            campaingn.Tags = input.request?.Tags;
            campaingn.Budget = input.request.Budget;


            _eventCampaingnRepository.Update(campaingn);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<UpdateEventCampaingnResponse>(campaingn);
        }
    }
}
