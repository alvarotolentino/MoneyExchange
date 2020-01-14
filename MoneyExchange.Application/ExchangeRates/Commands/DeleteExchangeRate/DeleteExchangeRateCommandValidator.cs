using FluentValidation;

namespace MoneyExchange.Application.ExchangeRates.Commands.DeleteExchangeRate
{
    public class DeleteExchangeRateCommandValidator: AbstractValidator<DeleteExchangeRateCommand>
    {
        public DeleteExchangeRateCommandValidator()
        {
            RuleFor(x => x.BaseSymbol).MinimumLength(3).NotEmpty();
            RuleFor(x => x.TargetSymbol).MinimumLength(3).NotEmpty();
        }
    }
}