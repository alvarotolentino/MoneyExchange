using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MoneyExchange.Application.ExchangeRates.Commands.UpdateExchangeRate
{
    public class UpdateExchangeRateCommandHandler: IRequestHandler<UpdateExchangeRateCommand>
    {
        public async Task<Unit> Handle(UpdateExchangeRateCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}