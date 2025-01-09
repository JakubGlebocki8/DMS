using AutoMapper;
using DMS.Application.DeviceCommad.AddDevice;
using DMS.Application.Devices;
using DMS.Application.UserCommand.AddUser;
using DMS.Application.UserQuerry.GetAllUsers;
using DMS.Domain;

namespace DMS.Application.Mappings
{
    public class DeviceMappingProfile : Profile
    {
        public DeviceMappingProfile()
        {
            CreateMap<Device, DeviceDto>()
                .ForMember(dto => dto.UserName, opt => opt.MapFrom(src => src.User.Name));

            CreateMap<AddDeviceCommand, Device>()
              .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
              .ForMember(dest => dest.serialNumber, opt => opt.MapFrom(src => src.SerialNumber))
              .ForMember(dest => dest.DayOfPurchase, opt => opt.MapFrom(src => src.DayOfPurchase))
              .ForMember(dest => dest.ReleaseDate, opt => opt.MapFrom(src => src.ReleaseDate))
              .ForMember(dest => dest.UserId, opt => opt.Ignore());
            CreateMap<User, UserDto>();
            CreateMap<AddUserCommand, User>();
        }
    }
}
