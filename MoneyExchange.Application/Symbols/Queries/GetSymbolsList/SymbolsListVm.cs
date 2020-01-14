using System.Collections.Generic;

namespace MoneyExchange.Application.Symbols.Queries.GetSymbolsList
{
    public class SymbolsListVm
    {
        public ICollection<(string Code, string Name)> Symbols { get; set; }
        public int Count { get; set; }
    }
}