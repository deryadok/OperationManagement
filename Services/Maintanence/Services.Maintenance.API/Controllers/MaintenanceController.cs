using Microsoft.AspNetCore.Mvc;
using Services.Maintenance.Business.MaintanenceHistoryServices;
using Services.Maintenance.Business.MaintanenceServices;
using Services.Maintenance.Model.DTO.Maintenance;
using Services.Maintenance.Model.DTO.MaintenanceHistory;
using Shared.CustomBaseController;

namespace Services.Maintenance.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MaintenanceController : BaseController
    {
        private readonly IMaintenanceService _maintenanceService;
        private readonly IMaintanenceHistoryService _maintenanceHistoryService;

        public MaintenanceController(IMaintenanceService maintenanceService, IMaintanenceHistoryService maintenanceHistoryService)
        {
            _maintenanceService = maintenanceService;
            _maintenanceHistoryService = maintenanceHistoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _maintenanceService.GetAll();
            return CreateActionResultInstance(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _maintenanceService.GetByID(id);
            return CreateActionResultInstance(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(MaintenanceInsertDto maintenance)
        {
            var response = await _maintenanceService.Add(maintenance);
            return CreateActionResultInstance(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(MaintenanceUpdateDto maintenance)
        {
            var response = await _maintenanceService.Update(maintenance);
            await _maintenanceHistoryService.Add(maintenance.MaintanenceHistory);
            return CreateActionResultInstance(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            MaintenanceDeleteDto maintenance = new MaintenanceDeleteDto() { ID = id };
            var response = await _maintenanceService.Remove(maintenance);
            return CreateActionResultInstance(response);
        }
    }
}
