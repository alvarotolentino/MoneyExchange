namespace MoneyExchange.Application.ExchangeRates.Queries.GetExchangeRateDetail
{
    public class GetExchangeRateDetailQuery
    {
        public string Base { get; set; }
        public string[] Target { get; set; }
    }
}