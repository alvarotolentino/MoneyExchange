using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace MoneyExchange.Application.ExchangeRates.Queries.GetExchangeRateDetail
{
    public class GetExchangeRateDetailVm
    {
        public string Base { get; set; }
        public DateAndTime Date { get; set; }

        public ICollection<(string Target, double Rate)> Rates { get; set; }
    }
}