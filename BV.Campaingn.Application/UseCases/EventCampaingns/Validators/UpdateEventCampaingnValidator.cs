using FluentValidation;

namespace BV.Campaingn.Application.UseCases.EventCampaingns.Create
{
    public sealed class UpdateEventCampaingnValidator : AbstractValidator<UpdateEventCampaingnRequest>
    {
        public UpdateEventCampaingnValidator()
        {
            RuleFor(x => x.request.Id).NotEmpty();
            RuleFor(x=> x.request.Name).NotEmpty().MinimumLength(10);
            RuleFor(x=> x.request.Description).NotEmpty().MinimumLength(90); 
        }
    }
}
