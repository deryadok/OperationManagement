using OperationsManagement.Shared.Entity;

namespace Services.Maintenance.Model.Model
{
    public class PictureGroup : BaseEntity
    {
        public string PictureImage { get; set; }

        public User User { get; set; }
        public List<MaintenanceEntity> Maintenances { get; set; }
    }
}
