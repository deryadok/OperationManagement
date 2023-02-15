using Microsoft.EntityFrameworkCore;
using OperationsManagement.Shared.GenericRepository;
using Services.ActionType.Model.Model;

namespace Services.ActionType.Data.Repository.UserRepository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }
    }
}
