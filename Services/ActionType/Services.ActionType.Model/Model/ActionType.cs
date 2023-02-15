using OperationsManagement.Shared.Entity;

namespace Services.ActionType.Model.Model
{
    public class ActionType : BaseEntity
    {
        public string Name { get; set; }

        public User User { get; set; }
    }
}
