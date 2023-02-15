using AutoMapper;
using Services.Maintenance.Model.DTO.ActionType;
using Services.Maintenance.Model.DTO.Maintenance;
using Services.Maintenance.Model.DTO.MaintenanceHistory;
using Services.Maintenance.Model.DTO.PictureGroup;
using Services.Maintenance.Model.DTO.Status;
using Services.Maintenance.Model.DTO.User;
using Services.Maintenance.Model.DTO.Vehicle;
using Services.Maintenance.Model.DTO.VehicleType;
using Services.Maintenance.Model.Model;

namespace Services.Maintenance.Model.Mappings
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<MaintenanceEntity, MaintenanceDto>().ReverseMap();
            CreateMap<MaintenanceEntity, MaintenanceInsertDto>().ReverseMap();
            CreateMap<MaintenanceEntity, MaintenanceUpdateDto>().ReverseMap();
            CreateMap<MaintenanceEntity, MaintenanceDeleteDto>().ReverseMap();

            CreateMap<MaintenanceHistory, MaintenanceHistoryDto>().ReverseMap();
            CreateMap<MaintenanceHistory, MaintenanceHistoryInsertDto>().ReverseMap();
            CreateMap<MaintenanceHistory, MaintenanceHistoryUpdateDto>().ReverseMap();
            CreateMap<MaintenanceHistory, MaintenanceHistoryDeleteDto>().ReverseMap();

            CreateMap<ActionType, ActionTypeDto>().ReverseMap();

            CreateMap<PictureGroup, PictureGroupDto>().ReverseMap();

            CreateMap<Status, StatusDto>().ReverseMap();

            CreateMap<User, UserDto>().ReverseMap();

            CreateMap<Vehicle, VehicleDto>().ReverseMap();

            CreateMap<VehicleType, VehicleTypeDto>().ReverseMap();

        }
    }
}
