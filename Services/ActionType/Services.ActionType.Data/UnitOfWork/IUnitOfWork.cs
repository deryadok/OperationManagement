using Services.ActionType.Data.Repository.ActionTypeRepository;
using Services.ActionType.Data.Repository.UserRepository;

namespace Services.ActionType.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IActionTypeRepository ActionTypeRepository { get; }
        IUserRepository UserRepository { get; }

        Task<int> Commit();
    }
}
