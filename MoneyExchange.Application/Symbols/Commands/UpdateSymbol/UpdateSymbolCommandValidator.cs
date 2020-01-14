using FluentValidation;

namespace MoneyExchange.Application.Symbols.Commands.UpdateSymbol
{
    public class UpdateSymbolCommandValidator : AbstractValidator<UpdateSymbolCommand>
    {
        public UpdateSymbolCommandValidator()
        {
            RuleFor(x => x.Code).MinimumLength(3).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}