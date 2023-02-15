using Microsoft.EntityFrameworkCore;
using OperationsManagement.Shared.GenericRepository;
using Services.Maintenance.Model.Model;

namespace Services.Maintenance.Data.Repository.ActionTypeRepository
{
    public class ActionTypeRepository : Repository<ActionType>, IActionTypeRepository
    {
        public ActionTypeRepository(DbContext context) : base(context)
        {
        }
    }
}
