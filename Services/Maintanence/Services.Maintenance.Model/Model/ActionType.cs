using OperationsManagement.Shared.Entity;

namespace Services.Maintenance.Model.Model
{
    public class ActionType : BaseEntity
    {
        public string Name { get; set; }

        public List<MaintenanceHistory> MaintenanceHistories { get; set; }
        public User User { get; set; }
    }
}
