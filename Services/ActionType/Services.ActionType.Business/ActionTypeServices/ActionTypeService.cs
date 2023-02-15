using AutoMapper;
using Services.ActionType.Data.UnitOfWork;
using Services.ActionType.Model.DTO.ActionType;
using Shared.Dtos;

namespace Services.ActionType.Business.ActionTypeServices
{
    public class ActionTypeService : IActionTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ActionTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response<NoContent>> Add(ActionTypeInsertDto entity)
        {
            try
            {
                Model.Model.ActionType actionType = _mapper.Map<Model.Model.ActionType>(entity);
                await _unitOfWork.ActionTypeRepository.Add(actionType);
                await _unitOfWork.Commit();

                return Response<NoContent>.Success(200);
            }
            catch (Exception ex)
            {
                return Response<NoContent>.Fail(ex.Message, 400);
            }
        }

        public async Task<Response<IEnumerable<ActionTypeDto>>> GetAll()
        {
            try
            {
                var entites = _mapper.Map<IEnumerable<ActionTypeDto>>(await _unitOfWork.ActionTypeRepository.GetAll());
                return Response<IEnumerable<ActionTypeDto>>.Success(entites, 200);
            }
            catch (Exception ex)
            {
                return Response<IEnumerable<ActionTypeDto>>.Fail(ex.Message, 404);
            }
        }

        public async Task<Response<ActionTypeDto>> GetByID(int id)
        {
            try
            {
                ActionTypeDto actionType = _mapper.Map<ActionTypeDto>(await _unitOfWork.ActionTypeRepository.GetByID(id));
                if (actionType != null)
                    return Response<ActionTypeDto>.Success(actionType, 200);
                else
                    return Response<ActionTypeDto>.Fail("The record is not founded", 404);

            }
            catch (Exception ex)
            {
                return Response<ActionTypeDto>.Fail(ex.Message, 400);
            }
        }

        public async Task<Response<NoContent>> Remove(ActionTypeDeleteDto entity)
        {
            try
            {
                Model.Model.ActionType actionType = _mapper.Map<Model.Model.ActionType>(GetByID(entity.ID));
                actionType.IsDeleted = true;
                actionType.ModifyDate = DateTime.Now;
                actionType.ModifiedBy = entity.ModifiedBy;
                await _unitOfWork.ActionTypeRepository.Remove(actionType);
                await _unitOfWork.Commit();

                return Response<NoContent>.Success(200);
            }
            catch (Exception ex)
            {
                return Response<NoContent>.Fail(ex.Message, 400);
            }
        }

        public async Task<Response<NoContent>> Update(ActionTypeUpdateDto entity)
        {
            try
            {
                Model.Model.ActionType actionType = _mapper.Map<Model.Model.ActionType>(entity);
                await _unitOfWork.ActionTypeRepository.Update(actionType);
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
