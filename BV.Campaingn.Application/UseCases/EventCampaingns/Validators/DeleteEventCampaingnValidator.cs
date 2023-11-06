using FluentValidation;

namespace BV.Campaingn.Application.UseCases.EventCampaingns.Create
{
    public sealed class DeleteEventCampaingnValidator : AbstractValidator<DeleteEventCampaingnRequest>
    {
        public DeleteEventCampaingnValidator()
        {
            RuleFor(x => x.id).NotEmpty(); 
        }
    }
}
