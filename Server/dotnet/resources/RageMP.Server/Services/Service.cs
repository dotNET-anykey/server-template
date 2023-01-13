using Microsoft.Extensions.DependencyInjection;
using RageMP.Infrastructure.Repositories.Interfaces;
using RageMP.Server.Services.Interfaces;

namespace RageMP.Server.Services
{
    public class Service : IService
    {
        private readonly IUnitOfWork _unitOfWork;

        public Service(IUnitOfWork unitOfWork, IServiceScopeFactory serviceScopeFactory)
        {
            this._unitOfWork = unitOfWork;
        }
    }
}