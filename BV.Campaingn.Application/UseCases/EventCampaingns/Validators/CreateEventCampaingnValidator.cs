using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV.Campaingn.Application.UseCases.EventCampaingns.Create
{
    public sealed class CreateEventCampaingnValidator : AbstractValidator<CreateEventCampaingnRequest>
    {
        public CreateEventCampaingnValidator()
        {
            RuleFor(x=> x.Name).NotEmpty().MinimumLength(8);
            RuleFor(x=> x.Description).NotEmpty().MinimumLength(90); 
        }
    }
}
