using Services.ActionType.Data.Context;
using Services.ActionType.Data.Repository.ActionTypeRepository;
using Services.ActionType.Data.Repository.UserRepository;

namespace Services.ActionType.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ActionTypeDbContext _actionTypeDbContext;

        public UnitOfWork(ActionTypeDbContext actionTypeDbContext)
        {
            _actionTypeDbContext = actionTypeDbContext;
        }

        #region Repositories
        private IActionTypeRepository _actionTypeRepository;
        public IActionTypeRepository ActionTypeRepository => _actionTypeRepository ?? new ActionTypeRepository(_actionTypeDbContext);

        private IUserRepository _userRepository;
        public IUserRepository UserRepository => _userRepository ?? new UserRepository(_actionTypeDbContext);
        #endregion
        public async Task<int> Commit()
        {
            return await _actionTypeDbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _actionTypeDbContext.Dispose();
        }
    }
}
