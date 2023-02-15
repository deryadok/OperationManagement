using OperationsManagement.Shared.Entity;

namespace Services.Maintenance.Model.Model
{
    public class Vehicle : BaseEntity
    {
        public string PlateNo { get; set; }
        public int VehicleTypeID { get; set; }
        public int UserID { get; set; }

        public User User { get; set; }
        public List<VehicleType> VehicleTypes { get; set; }
    }
}
