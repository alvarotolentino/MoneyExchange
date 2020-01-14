using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MoneyExchange.Application.ExchangeRates.Queries.GetConversion
{
    public class GetConversionQueryHandler: IRequestHandler<GetConversionQuery, GetConversionVm>
    {
        public async Task<GetConversionVm> Handle(GetConversionQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}