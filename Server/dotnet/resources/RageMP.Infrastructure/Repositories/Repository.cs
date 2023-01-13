using RageMP.Infrastructure.Repositories.Interfaces;

namespace RageMP.Infrastructure.Repositories
{
    public class Repository : IRepository
    {
        private readonly DatabaseContext _databaseContext;

        public Repository(DatabaseContext context)
        {
            this._databaseContext = context;
        }
    }
}
