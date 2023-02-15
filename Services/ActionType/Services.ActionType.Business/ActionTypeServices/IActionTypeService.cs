using Services.ActionType.Model.DTO.ActionType;
using Shared.Dtos;

namespace Services.ActionType.Business.ActionTypeServices
{
    public interface IActionTypeService
    {
        Task<Response<ActionTypeDto>> GetByID(int id);
        Task<Response<IEnumerable<ActionTypeDto>>> GetAll();
        Task<Response<NoContent>> Add(ActionTypeInsertDto entity);
        Task<Response<NoContent>> Update(ActionTypeUpdateDto entity);
        Task<Response<NoContent>> Remove(ActionTypeDeleteDto entity);
    }
}
