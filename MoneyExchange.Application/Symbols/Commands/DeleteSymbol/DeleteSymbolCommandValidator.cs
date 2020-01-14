using FluentValidation;

namespace MoneyExchange.Application.Symbols.Commands.DeleteSymbol
{
    public class DeleteSymbolCommandValidator: AbstractValidator<DeleteSymbolCommand>
    {
        public DeleteSymbolCommandValidator()
        {
            RuleFor(x => x.Code).MinimumLength(3).NotEmpty();
        }
    }
}