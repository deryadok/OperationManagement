using Microsoft.Data.SqlClient;
using Services.Maintenance.Data.Context;
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
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Maintenance.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MaintenanceDbContext _maintenanceDbContext;

        public UnitOfWork(MaintenanceDbContext maintenanceDbContext)
        {
            _maintenanceDbContext = maintenanceDbContext;
        }

        #region Repositories
        private IActionTypeRepository _actionTypeRepository;
        public IActionTypeRepository ActionTypeRepository => _actionTypeRepository ?? new ActionTypeRepository(_maintenanceDbContext);

        private IMaintenanceRepository _maintenanceRepository;
        public IMaintenanceRepository MaintenanceRepository => _maintenanceRepository ?? new MaintenanceRepository(_maintenanceDbContext);

        private IMaintenanceHistoryRepository _maintenanceHistoryRepository;
        public IMaintenanceHistoryRepository MaintenanceHistoryRepository => _maintenanceHistoryRepository ?? new MaintenanceHistoryRepository(_maintenanceDbContext);

        private IPictureGroupRepository _pictureGroupRepository;
        public IPictureGroupRepository PictureGroupRepository => _pictureGroupRepository ?? new PictureGroupRepository(_maintenanceDbContext);

        private IStatusRepository _statusRepository;
        public IStatusRepository StatusRepository => _statusRepository ?? new StatusRepository(_maintenanceDbContext);

        private IUserRepository _userRepository;
        public IUserRepository UserRepository => _userRepository ?? new UserRepository(_maintenanceDbContext);

        private IVehicleRepository _vehicleRepository;
        public IVehicleRepository VehicleRepository => _vehicleRepository ?? new VehicleRepository(_maintenanceDbContext);

        private IVehicleTypeRepository _vehicleTypeRepository;
        public IVehicleTypeRepository VehicleTypeRepository => _vehicleTypeRepository ?? new VehicleTypeRepository(_maintenanceDbContext);
        #endregion

        public async Task<int> Commit()
        {
            return await _maintenanceDbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _maintenanceDbContext.Dispose();
        }
    }
}
