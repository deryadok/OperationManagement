using OperationsManagement.Shared.Entity;

namespace Services.Maintenance.Model.Model
{
    public class Status : BaseEntity
    {
        public string Name { get; set; }
        public List<MaintenanceEntity> Maintenances { get; set; }
    }
}
