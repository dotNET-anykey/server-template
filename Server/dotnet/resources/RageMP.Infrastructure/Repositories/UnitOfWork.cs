using Infrastructure.Repositories.Interfaces;

namespace Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _databaseContext;

        public IRepository Repository { get; }

        public UnitOfWork(DatabaseContext databaseContext, IRepository repository)
        {
            this._databaseContext = databaseContext;

            Repository = repository;
        }

        public async Task Save()
        {
            await this._databaseContext.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task Dispose()
        {
            await Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual async Task Dispose(bool disposing)
        {
            if (disposing)
            {
                await this._databaseContext.DisposeAsync();
            }
        }
    }
}
