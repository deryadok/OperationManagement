using Shared.Dtos.BaseDtos;

namespace Services.Maintenance.Model.DTO.MaintenanceHistory
{
    public class MaintenanceHistoryInsertDto : BaseInsertDto
    {
        public string Text { get; set; }
    }
}
