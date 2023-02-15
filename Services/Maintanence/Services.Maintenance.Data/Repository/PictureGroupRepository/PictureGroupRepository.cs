using Microsoft.EntityFrameworkCore;
using OperationsManagement.Shared.GenericRepository;
using Services.Maintenance.Model.Model;

namespace Services.Maintenance.Data.Repository.PictureGroupRepository
{
    public class PictureGroupRepository : Repository<PictureGroup>, IPictureGroupRepository
    {
        public PictureGroupRepository(DbContext context) : base(context)
        {
        }
    }
}
