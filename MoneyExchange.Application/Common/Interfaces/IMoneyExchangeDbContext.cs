using System.Threading;
using System.Threading.Tasks;

namespace MoneyExchange.Application.Common.Interfaces
{
    interface IMoneyExchangeDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
