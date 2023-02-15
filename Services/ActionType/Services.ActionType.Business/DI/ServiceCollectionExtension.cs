using Microsoft.Extensions.DependencyInjection;
using OperationsManagement.Shared.GenericRepository;
using Services.ActionType.Business.ActionTypeServices;
using Services.ActionType.Data.UnitOfWork;

namespace Services.ActionType.Business.DI
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<IActionTypeService, ActionTypeService>();


            return services;
        }
    }
}
