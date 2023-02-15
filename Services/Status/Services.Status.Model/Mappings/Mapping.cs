using AutoMapper;
using Services.Status.Model.DTO.Status;
using Services.Status.Model.DTO.User;
using Services.Status.Model.Model;

namespace Services.Status.Model.Mappings
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<StatusEntity, StatusDto>().ReverseMap();
            CreateMap<StatusEntity, StatusInsertDto>().ReverseMap();
            CreateMap<StatusEntity, StatusUpdateDto>().ReverseMap();
            CreateMap<StatusEntity, StatusDeleteDto>().ReverseMap();

            CreateMap<User, UserDto>().ReverseMap();


        }
    }
}
