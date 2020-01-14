using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MoneyExchange.Application.Symbols.Commands.UpdateSymbol
{
    public class UpdateSymbolCommandHandler: IRequestHandler<UpdateSymbolCommand>
    {
        public async Task<Unit> Handle(UpdateSymbolCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}