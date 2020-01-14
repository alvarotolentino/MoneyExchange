using System.Collections.Generic;

namespace MoneyExchange.Application.ExchangeRates.Queries.GetConversion
{
    public class GetConversionVm
    {
        public string Base { get; set; }
        public double Amount { get; set; }
        public ICollection<(string Target, double Converted)> Conversion { get; set; }
    }
}