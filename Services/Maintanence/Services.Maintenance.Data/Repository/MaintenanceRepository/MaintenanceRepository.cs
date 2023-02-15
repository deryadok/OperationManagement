using Microsoft.EntityFrameworkCore;
using OperationsManagement.Shared.GenericRepository;
using Services.Maintenance.Model.Model;

namespace Services.Maintenance.Data.Repository.MaintenanceRepository
{
    public class MaintenanceRepository : Repository<MaintenanceEntity>, IMaintenanceRepository
    {
        public MaintenanceRepository(DbContext context) : base(context)
        {
        }
    }
}
