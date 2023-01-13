using Infrastructure.Repositories.Interfaces;

namespace Infrastructure.Repositories
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
