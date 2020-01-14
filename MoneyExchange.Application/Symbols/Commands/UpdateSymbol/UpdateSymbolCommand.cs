using MediatR;

namespace MoneyExchange.Application.Symbols.Commands.UpdateSymbol
{
    public class UpdateSymbolCommand: IRequest
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}