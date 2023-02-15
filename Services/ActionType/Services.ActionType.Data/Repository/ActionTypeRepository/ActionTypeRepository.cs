using Microsoft.EntityFrameworkCore;
using OperationsManagement.Shared.GenericRepository;

namespace Services.ActionType.Data.Repository.ActionTypeRepository
{
    public class ActionTypeRepository : Repository<Model.Model.ActionType>, IActionTypeRepository
    {
        public ActionTypeRepository(DbContext context) : base(context)
        {
        }
    }
}
