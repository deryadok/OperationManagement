using Microsoft.EntityFrameworkCore;
using OperationsManagement.Shared.GenericRepository;
using Services.Maintenance.Model.Model;

namespace Services.Maintenance.Data.Repository.StatusRepository
{
    public class StatusRepository : Repository<Status>, IStatusRepository
    {
        public StatusRepository(DbContext context) : base(context)
        {
        }
    }
}
