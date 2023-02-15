using Services.Maintenance.Model.DTO.Maintenance;
using Shared.Dtos.BaseDtos;

namespace Services.Maintenance.Model.DTO.MaintenanceHistory
{
    public class MaintenanceHistoryDto : BaseDto
    {
        public string Text { get; set; }

        public MaintenanceDto Maintenance { get; set; }

    }
}
