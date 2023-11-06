using BV.Campaingn.Application.UseCases.EventCampaingns.Create;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BV.Campaingn.Api.Controllers
{
    [Route("event-campaingn")]
    [ApiController]
    public class EventCampaingnController: ControllerBase
    {
        private readonly IMediator _mediator;
        public EventCampaingnController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<CreateEventCampaingnResponse>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetEventsCampaingnRequest(), cancellationToken);

            if(response?.Count == 0)
            {
                throw new KeyNotFoundException("Nenhuma campanha encontrada.");
            }

            return Ok(response);

        }

        [HttpPost]
        public async Task<ActionResult<CreateEventCampaingnResponse>> Create(CreateEventCampaingnRequest request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);

            return Ok(response);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CreateEventCampaingnResponse>> Update(int id, UpdateEventCampaingnRequest request, CancellationToken cancellationToken)
        {
            if(id != request.request?.Id)
            {
                return BadRequest();
            } 

            var response = await _mediator.Send(request, cancellationToken);
            
            return Ok(response);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CreateEventCampaingnResponse>> Delete(int id, CancellationToken cancellationToken)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var request = new DeleteEventCampaingnRequest(id);
            var response = await _mediator.Send(request, cancellationToken);

            return Ok(response);

        }
    }
}
