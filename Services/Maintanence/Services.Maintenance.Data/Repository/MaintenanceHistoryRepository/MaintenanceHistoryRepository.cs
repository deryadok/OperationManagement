using Microsoft.EntityFrameworkCore;
using OperationsManagement.Shared.GenericRepository;
using Services.Maintenance.Model.Model;

namespace Services.Maintenance.Data.Repository.MaintenanceHistoryRepository
{
    public class MaintenanceHistoryRepository : Repository<MaintenanceHistory>, IMaintenanceHistoryRepository
    {
        public MaintenanceHistoryRepository(DbContext context) : base(context)
        {
        }
    }
}
