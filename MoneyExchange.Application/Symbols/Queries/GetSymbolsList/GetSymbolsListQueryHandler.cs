using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MoneyExchange.Application.Symbols.Queries.GetSymbolsList
{
    public class GetSymbolsListQueryHandler:IRequestHandler<GetSymbolsListQuery, SymbolsListVm>
    {
        public async Task<SymbolsListVm> Handle(GetSymbolsListQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}