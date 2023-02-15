using Microsoft.Extensions.DependencyInjection;
using OperationsManagement.Shared.GenericRepository;
using Services.Maintenance.Business.MaintanenceHistoryServices;
using Services.Maintenance.Business.MaintanenceServices;
using Services.Maintenance.Data.UnitOfWork;

namespace Services.Maintenance.Business.DI
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<IMaintenanceService, MaintanenceService>();
            services.AddScoped<IMaintanenceHistoryService, MaintanenceHistoryService>();

            return services;
        }
    }
}
