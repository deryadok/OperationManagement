using OperationsManagement.Shared.Entity;

namespace Services.Maintenance.Model.Model
{
    public class MaintenanceHistory : BaseEntity
    {
        public string Text { get; set; }

        public MaintenanceEntity Maintenance { get; set; }
        public User User { get; set; }
    }
}
