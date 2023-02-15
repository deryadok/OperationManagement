using Microsoft.EntityFrameworkCore;
using OperationsManagement.Shared.GenericRepository;
using Services.Maintenance.Model.Model;

namespace Services.Maintenance.Data.Repository.UserRepository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }
    }
}
