using MediatR;

namespace MoneyExchange.Application.Symbols.Commands.DeleteSymbol
{
    public class DeleteSymbolCommand: IRequest
    {
        public string Code { get; set; }

    }
}