namespace Infrastructure.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        public IRepository Repository { get; }

        Task Save();
        Task Dispose();
    }
}
