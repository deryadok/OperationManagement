using AutoMapper;
using Services.ActionType.Model.DTO.ActionType;
using Services.ActionType.Model.DTO.User;
using Services.ActionType.Model.Model;

namespace Services.ActionType.Model.Mappings
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Model.ActionType, ActionTypeDto>().ReverseMap();
            CreateMap<Model.ActionType, ActionTypeInsertDto>().ReverseMap();
            CreateMap<Model.ActionType, ActionTypeUpdateDto>().ReverseMap();
            CreateMap<Model.ActionType, ActionTypeDeleteDto>().ReverseMap();

            CreateMap<User, UserDto>().ReverseMap();


        }
    }
}
