using System;
using MoneyExchange.Domain.Common;

namespace MoneyExchange.Domain.Entities
{
    public class Rate: AuditableEntity
    {
        public int RateId { get; set; }
        public int BaseId { get; set; }
        public Symbol Base { get; set; }
        public int TargetId { get; set; }
        public Symbol Target { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }

    }
}