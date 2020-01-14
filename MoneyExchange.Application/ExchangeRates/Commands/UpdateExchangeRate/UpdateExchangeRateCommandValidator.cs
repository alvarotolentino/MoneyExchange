using FluentValidation;

namespace MoneyExchange.Application.ExchangeRates.Commands.UpdateExchangeRate
{
    public class UpdateExchangeRateCommandValidator: AbstractValidator<UpdateExchangeRateCommand>
    {
        public UpdateExchangeRateCommandValidator()
        {
            RuleFor(x => x.Base).MinimumLength(3).NotEmpty();
            RuleFor(x => x.TargetSymbols).NotEmpty();
            RuleFor(x => x.Rate).GreaterThan(0);
        }    
    }
}