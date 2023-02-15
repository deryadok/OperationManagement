using OperationsManagement.Shared.Entity;

namespace Services.Maintenance.Model.Model
{
    public class MaintenanceEntity : BaseEntity
    {
        public int VehicleID { get; set; }
        public int UserID { get; set; }
        public string Description { get; set; }
        public int PictureGroupID { get; set; }
        public DateTime ExpectedTimeToFix { get; set; }
        public int ResponsibleUserID { get; set; }
        public string LocationLongitude { get; set; }
        public string LocationLatitude { get; set; }
        public int StatusID { get; set; }

        public List<MaintenanceHistory> MaintenanceHistories { get; set; }
        public Vehicle Vehicle { get; set; }
        public User User { get; set; }
        public PictureGroup PictureGroup { get; set; }
        public Status Status { get; set; }
    }
}