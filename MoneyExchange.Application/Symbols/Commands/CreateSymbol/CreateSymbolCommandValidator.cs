using FluentValidation;

namespace MoneyExchange.Application.Symbols.Commands.CreateSymbol
{
    public class CreateSymbolCommandValidator: AbstractValidator<CreateSymbolCommand>
    {
        public CreateSymbolCommandValidator()
        {
            RuleFor(x => x.Code).MinimumLength(3).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}