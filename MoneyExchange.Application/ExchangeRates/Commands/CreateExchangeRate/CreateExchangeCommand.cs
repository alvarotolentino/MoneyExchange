using System;
using MediatR;

namespace MoneyExchange.Application.ExchangeRates.Commands.CreateExchangeRate
{
    public class CreateExchangeCommand: IRequest<int>
    {
        public string Base { get; set; }
        public string[] TargetSymbols { get; set; }
        public double Rate { get; set; }

    }
}
