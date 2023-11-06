using AutoMapper;
using BV.Campaingn.Domain.Entities;
using BV.Campaingn.Domain.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV.Campaingn.Application.UseCases.EventCampaingns.Create
{
    public sealed class CreateEventCampaingnHandler : IRequestHandler<CreateEventCampaingnRequest, CreateEventCampaingnResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEventCampaingnRepository _eventCampaingnRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateEventCampaingnHandler> _logger;

        public CreateEventCampaingnHandler(
            IUnitOfWork unitOfWork, 
            IEventCampaingnRepository eventCampaingnRepository, 
            IMapper mapper, 
            ILogger<CreateEventCampaingnHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _eventCampaingnRepository = eventCampaingnRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<CreateEventCampaingnResponse> Handle(CreateEventCampaingnRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Creating campaingn {request}");
            var campaingn = _mapper.Map<EventCampaingn>(request);

            campaingn.DateCreated = DateTimeOffset.Now;
            campaingn.DateUpdated = DateTimeOffset.Now;

            _eventCampaingnRepository.Create(campaingn);

            await _unitOfWork.Commit(cancellationToken);

            _logger.LogInformation($"Created campaingn {request.Name}");

            return _mapper.Map<CreateEventCampaingnResponse>(campaingn);
        }
    }
}
