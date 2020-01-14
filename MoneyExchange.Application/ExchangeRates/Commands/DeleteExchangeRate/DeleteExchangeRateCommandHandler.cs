using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MoneyExchange.Application.ExchangeRates.Commands.DeleteExchangeRate
{
    public class DeleteExchangeRateCommandHandler: IRequestHandler<DeleteExchangeRateCommand>
    {
        public async Task<Unit> Handle(DeleteExchangeRateCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}