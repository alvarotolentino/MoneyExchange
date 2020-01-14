using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MoneyExchange.Application.Symbols.Commands.CreateSymbol
{
    public class CreateSymbolCommandHandler: IRequestHandler<CreateSymbolCommand, int>
    {
        public async Task<int> Handle(CreateSymbolCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}