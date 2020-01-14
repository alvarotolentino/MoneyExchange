using MediatR;

namespace MoneyExchange.Application.ExchangeRates.Queries.GetConversion
{
    public class GetConversionQuery : IRequest<GetConversionVm>
    {
        public string Base { get; set; }
        public double Amount { get; set; }
        public string[] TargetSymbols { get; set; }

    }
}