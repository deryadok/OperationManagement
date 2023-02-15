using AutoMapper;
using Services.Maintenance.Data.UnitOfWork;
using Services.Maintenance.Model.DTO.Maintenance;
using Services.Maintenance.Model.Model;
using Shared.Dtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.Maintenance.Business.MaintanenceServices
{
    public class MaintanenceService : IMaintenanceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public MaintanenceService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response<NoContent>> Add(MaintenanceInsertDto entity)
        {
            try
            {
                MaintenanceEntity maintanence = _mapper.Map<MaintenanceEntity>(entity);
                await _unitOfWork.MaintenanceRepository.Add(maintanence);
                await _unitOfWork.Commit();

                return Response<NoContent>.Success(200);
            }
            catch (Exception ex)
            {
                return Response<NoContent>.Fail(ex.Message, 400);
            }
        }

        public async Task<Response<IEnumerable<MaintenanceDto>>> GetAll()
        {
            try
            {
                var entites = _mapper.Map<IEnumerable<MaintenanceDto>>(await _unitOfWork.MaintenanceRepository.GetAll());
                return Response<IEnumerable<MaintenanceDto>>.Success(entites, 200);
            }
            catch (Exception ex)
            {
                return Response<IEnumerable<MaintenanceDto>>.Fail(ex.Message, 404);
            }
        }

        public async Task<Response<MaintenanceDto>> GetByID(int id)
        {
            try
            {
                MaintenanceDto maintenance = _mapper.Map<MaintenanceDto>(await _unitOfWork.MaintenanceRepository.GetByID(id));
                if (maintenance != null)
                    return Response<MaintenanceDto>.Success(maintenance, 200);
                else
                    return Response<MaintenanceDto>.Fail("The record is not founded", 404);

            }
            catch (Exception ex)
            {
                return Response<MaintenanceDto>.Fail(ex.Message, 400);
            }
        }

        public async Task<Response<NoContent>> Remove(MaintenanceDeleteDto entity)
        {
            try
            {
                MaintenanceEntity maintanence = _mapper.Map<MaintenanceEntity>(entity);

                await _unitOfWork.MaintenanceRepository.Remove(maintanence);
                await _unitOfWork.Commit();

                return Response<NoContent>.Success(200);
            }
            catch (Exception ex)
            {
                return Response<NoContent>.Fail(ex.Message, 400);
            }
        }

        public async Task<Response<NoContent>> Update(MaintenanceUpdateDto entity)
        {
            try
            {
                MaintenanceEntity maintanence = _mapper.Map<MaintenanceEntity>(entity);

                await _unitOfWork.MaintenanceRepository.Update(maintanence);
                await _unitOfWork.Commit();

                return Response<NoContent>.Success(200);
            }
            catch (Exception ex)
            {
                return Response<NoContent>.Fail(ex.Message, 400);
            }
        }
    }
}
