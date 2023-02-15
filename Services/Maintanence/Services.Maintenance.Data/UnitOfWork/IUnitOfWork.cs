using Services.Maintenance.Data.Repository;
using Services.Maintenance.Data.Repository.ActionTypeRepository;
using Services.Maintenance.Data.Repository.MaintenanceHistoryRepository;
using Services.Maintenance.Data.Repository.MaintenanceRepository;
using Services.Maintenance.Data.Repository.PictureGroupRepository;
using Services.Maintenance.Data.Repository.StatusRepository;
using Services.Maintenance.Data.Repository.UserRepository;
using Services.Maintenance.Data.Repository.VehicleRepository;
using Services.Maintenance.Data.Repository.VehicleTypeRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Maintenance.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IActionTypeRepository ActionTypeRepository { get; }
        IMaintenanceRepository MaintenanceRepository { get; }
        IMaintenanceHistoryRepository MaintenanceHistoryRepository { get; }
        IPictureGroupRepository PictureGroupRepository { get; }
        IStatusRepository StatusRepository { get; }
        IUserRepository UserRepository { get; }
        IVehicleRepository  VehicleRepository { get; }
        IVehicleTypeRepository VehicleTypeRepository { get; }

        Task<int> Commit();
    }
}
