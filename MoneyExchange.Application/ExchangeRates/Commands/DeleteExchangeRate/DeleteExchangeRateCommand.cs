using MediatR;

namespace MoneyExchange.Application.ExchangeRates.Commands.DeleteExchangeRate
{
    public class DeleteExchangeRateCommand: IRequest
    {
        public string BaseSymbol { get; set; }
        public string TargetSymbol { get; set; }
    }
}