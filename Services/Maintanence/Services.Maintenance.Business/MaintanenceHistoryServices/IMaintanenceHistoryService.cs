using Services.Maintenance.Model.DTO.Maintenance;
using Services.Maintenance.Model.DTO.MaintenanceHistory;
using Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Maintenance.Business.MaintanenceHistoryServices
{
    public interface IMaintanenceHistoryService
    {
        Task<Response<MaintenanceHistoryDto>> GetByID(int id);
        Task<Response<IEnumerable<MaintenanceHistoryDto>>> GetAll();
        Task<Response<NoContent>> Add(MaintenanceHistoryInsertDto entity);
        Task<Response<NoContent>> Update(MaintenanceHistoryUpdateDto entity);
        Task<Response<NoContent>> Remove(MaintenanceHistoryDeleteDto entity);
    }
}
