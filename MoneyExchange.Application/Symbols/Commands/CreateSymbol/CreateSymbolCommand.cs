using MediatR;

namespace MoneyExchange.Application.Symbols.Commands.CreateSymbol
{
    public class CreateSymbolCommand: IRequest<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }

    }
}