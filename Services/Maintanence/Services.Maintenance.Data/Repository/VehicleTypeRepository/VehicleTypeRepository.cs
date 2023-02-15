using Microsoft.EntityFrameworkCore;
using OperationsManagement.Shared.GenericRepository;
using Services.Maintenance.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Maintenance.Data.Repository.VehicleTypeRepository
{
    public class VehicleTypeRepository : Repository<VehicleType>, IVehicleTypeRepository
    {
        public VehicleTypeRepository(DbContext context) : base(context)
        {
        }
    }
}
