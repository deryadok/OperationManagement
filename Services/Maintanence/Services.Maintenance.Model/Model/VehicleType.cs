using OperationsManagement.Shared.Entity;

namespace Services.Maintenance.Model.Model
{
    public class VehicleType : BaseEntity
    {
        public string Name { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}
