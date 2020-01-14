using MediatR;

namespace MoneyExchange.Application.ExchangeRates.Commands.UpdateExchangeRate
{
    public class UpdateExchangeRateCommand: IRequest
    {
        public string Base { get; set; }
        public string[] TargetSymbols { get; set; }
        public double Rate { get; set; }
    }
}