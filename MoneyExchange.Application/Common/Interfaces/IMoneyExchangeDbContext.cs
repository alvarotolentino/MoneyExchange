using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoneyExchange.Domain.Entities;

namespace MoneyExchange.Application.Common.Interfaces
{
    public interface IMoneyExchangeDbContext
    {
        DbSet<Symbol> Symbols { get; set; }
        DbSet<Rate> Rates { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
