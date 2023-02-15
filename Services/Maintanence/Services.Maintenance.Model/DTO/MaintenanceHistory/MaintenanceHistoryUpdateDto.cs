using Shared.Dtos.BaseDtos;

namespace Services.Maintenance.Model.DTO.MaintenanceHistory
{
    public class MaintenanceHistoryUpdateDto : BaseUpdateDto
    {
        public string Text { get; set; }

    }
}
