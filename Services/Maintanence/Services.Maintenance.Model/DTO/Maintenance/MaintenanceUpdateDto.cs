using Shared.Dtos.BaseDtos;
using Services.Maintenance.Model.DTO.PictureGroup;
using Services.Maintenance.Model.DTO.Status;
using Services.Maintenance.Model.DTO.User;
using Services.Maintenance.Model.DTO.Vehicle;
using Services.Maintenance.Model.DTO.MaintenanceHistory;

namespace Services.Maintenance.Model.DTO.Maintenance
{
    public class MaintenanceUpdateDto : BaseUpdateDto
    {
        public VehicleDto Vehicle { get; set; }
        public string Description { get; set; }
        public PictureGroupDto PictureGroup { get; set; }
        public DateTime ExpectedTimeToFix { get; set; }
        public UserDto ResponsibleUser { get; set; }
        public string LocationLongitude { get; set; }
        public string LocationLatitude { get; set; }
        public StatusDto Status { get; set; }
        public MaintenanceHistoryInsertDto MaintanenceHistory { get; set; }
    }
}
