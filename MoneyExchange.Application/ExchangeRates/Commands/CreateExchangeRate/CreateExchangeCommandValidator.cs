using FluentValidation;

namespace MoneyExchange.Application.ExchangeRates.Commands.CreateExchangeRate
{
    public class CreateExchangeCommandValidator: AbstractValidator<CreateExchangeCommand>
    {
        public CreateExchangeCommandValidator()
        {
            RuleFor(x => x.Base).MinimumLength(3).NotEmpty();
            RuleFor(x => x.TargetSymbols).NotEmpty();
            RuleFor(x => x.Rate).GreaterThan(0);
        }
    }
}