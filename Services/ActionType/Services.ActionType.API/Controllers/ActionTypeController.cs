using Microsoft.AspNetCore.Mvc;
using Services.ActionType.Business.ActionTypeServices;
using Services.ActionType.Model.DTO.ActionType;
using Shared.CustomBaseController;

namespace Services.ActionType.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActionTypeController : BaseController
    { 
        private readonly IActionTypeService _actionTypeService;

        public ActionTypeController(IActionTypeService actionTypeService)
        {
            _actionTypeService = actionTypeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _actionTypeService.GetAll();
            return CreateActionResultInstance(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _actionTypeService.GetByID(id);
            return CreateActionResultInstance(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ActionTypeInsertDto actionType)
        {
            var response = await _actionTypeService.Add(actionType);
            return CreateActionResultInstance(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ActionTypeUpdateDto actionType)
        {
            var response = await _actionTypeService.Update(actionType);
            return CreateActionResultInstance(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            ActionTypeDeleteDto actionType = new ActionTypeDeleteDto() { ID = id };
            var response = await _actionTypeService.Remove(actionType);
            return CreateActionResultInstance(response);
        }
    }
}
