using Services.Maintenance.Model.DTO.Maintenance;
using Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.Maintenance.Business.MaintanenceServices
{
    public interface IMaintenanceService
    {
        Task<Response<MaintenanceDto>> GetByID(int id);
        Task<Response<IEnumerable<MaintenanceDto>>> GetAll();
        Task<Response<NoContent>> Add(MaintenanceInsertDto entity);
        Task<Response<NoContent>> Update(MaintenanceUpdateDto entity);
        Task<Response<NoContent>> Remove(MaintenanceDeleteDto entity);
    }
}
