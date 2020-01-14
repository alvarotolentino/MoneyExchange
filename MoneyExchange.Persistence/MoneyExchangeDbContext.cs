using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoneyExchange.Application.Common.Interfaces;
using MoneyExchange.Domain.Common;
using MoneyExchange.Domain.Entities;

namespace MoneyExchange.Persistence
{
    public class MoneyExchangeDbContext: DbContext, IMoneyExchangeDbContext
    {
        public MoneyExchangeDbContext(DbContextOptions<MoneyExchangeDbContext> options)
        :base(options)
        {
            
        }

        public DbSet<Symbol> Symbols { get; set; }
        public DbSet<Rate> Rates { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = "USER_ID";
                        entry.Entity.Created = DateTime.UtcNow;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = "USER_ID";
                        entry.Entity.LastModified = DateTime.UtcNow;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MoneyExchangeDbContext).Assembly);
        }
    }
}