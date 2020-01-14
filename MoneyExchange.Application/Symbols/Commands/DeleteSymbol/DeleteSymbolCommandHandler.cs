using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MoneyExchange.Application.Symbols.Commands.DeleteSymbol
{
    public class DeleteSymbolCommandHandler: IRequestHandler<DeleteSymbolCommand>
    {
        public async Task<Unit> Handle(DeleteSymbolCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}