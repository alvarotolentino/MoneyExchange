using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MoneyExchange.Application.ExchangeRates.Commands.CreateExchangeRate
{
    public class CreateExchangeCommandHandler: IRequestHandler<CreateExchangeCommand, int>
    {
        public async Task<int> Handle(CreateExchangeCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}