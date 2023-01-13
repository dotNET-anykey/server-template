using Infrastructure.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Server.Services.Interfaces;

namespace Server.Services
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