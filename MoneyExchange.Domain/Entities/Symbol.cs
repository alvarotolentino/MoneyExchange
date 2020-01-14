using System.Collections.Generic;
using MoneyExchange.Domain.Common;

namespace MoneyExchange.Domain.Entities
{
    public class Symbol : AuditableEntity
    {
        public Symbol()
        {
            Base = new HashSet<Rate>();
            Targets = new HashSet<Rate>();
        }
        public int SymbolId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public ICollection<Rate> Base { get; set; }
        public ICollection<Rate> Targets { get; set; }

    }
}