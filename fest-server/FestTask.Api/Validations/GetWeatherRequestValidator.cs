using FestTask.Api.DTOs;
using FestTask.Application.Enums;
using FluentValidation;

namespace FestTask.Api.Validations
{
    public class GetWeatherRequestValidator: AbstractValidator<GetWeatherRequest>
    {
        public GetWeatherRequestValidator()
        {
            RuleFor(r => r.ZipCode)
                .NotEmpty();

            RuleFor(r => r.Units)
                .IsInEnum();
        }
    }
}
