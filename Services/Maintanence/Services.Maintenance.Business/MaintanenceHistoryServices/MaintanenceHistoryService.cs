using AutoMapper;
using Services.Maintenance.Data.UnitOfWork;
using Services.Maintenance.Model.DTO.Maintenance;
using Services.Maintenance.Model.DTO.MaintenanceHistory;
using Services.Maintenance.Model.Model;
using Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Maintenance.Business.MaintanenceHistoryServices
{
    public class MaintanenceHistoryService : IMaintanenceHistoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MaintanenceHistoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response<NoContent>> Add(MaintenanceHistoryInsertDto entity)
        {
            try
            {
                MaintenanceHistory maintanence = _mapper.Map<MaintenanceHistory>(entity);
                await _unitOfWork.MaintenanceHistoryRepository.Add(maintanence);
                await _unitOfWork.Commit();

                return Response<NoContent>.Success(200);
            }
            catch (Exception ex)
            {
                return Response<NoContent>.Fail(ex.Message, 400);
            }
        }

        public async Task<Response<IEnumerable<MaintenanceHistoryDto>>> GetAll()
        {
            try
            {
                var entites = _mapper.Map<IEnumerable<MaintenanceHistoryDto>>(await _unitOfWork.MaintenanceHistoryRepository.GetAll());
                return Response<IEnumerable<MaintenanceHistoryDto>>.Success(entites, 200);
            }
            catch (Exception ex)
            {
                return Response<IEnumerable<MaintenanceHistoryDto>>.Fail(ex.Message, 404);
            }
        }

        public async Task<Response<MaintenanceHistoryDto>> GetByID(int id)
        {
            try
            {
                MaintenanceHistoryDto maintenanceHistory = _mapper.Map<MaintenanceHistoryDto>(await _unitOfWork.MaintenanceHistoryRepository.GetByID(id));
                if (maintenanceHistory == null)
                    return Response<MaintenanceHistoryDto>.Success(maintenanceHistory, 200);
                else
                    return Response<MaintenanceHistoryDto>.Fail("The record is not founded", 404);
            }
            catch (Exception ex)
            {
                return Response<MaintenanceHistoryDto>.Fail(ex.Message, 404);
            }
        }

        public async Task<Response<NoContent>> Remove(MaintenanceHistoryDeleteDto entity)
        {
            try
            {
                MaintenanceHistory maintanence = _mapper.Map<MaintenanceHistory>(entity);
                await _unitOfWork.MaintenanceHistoryRepository.Remove(maintanence);
                await _unitOfWork.Commit();

                return Response<NoContent>.Success(200);
            }
            catch (Exception ex)
            {
                return Response<NoContent>.Fail(ex.Message, 400);
            }
        }

        public async Task<Response<NoContent>> Update(MaintenanceHistoryUpdateDto entity)
        {
            try
            {
                MaintenanceHistory maintanence = _mapper.Map<MaintenanceHistory>(entity);
                await _unitOfWork.MaintenanceHistoryRepository.Update(maintanence);
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
