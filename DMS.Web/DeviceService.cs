using DMS.Application.DeviceCommad;
using DMS.Application.DeviceCommad.AddDevice;
using DMS.Application.DeviceCommad.DeleteDevice;
using DMS.Application.DeviceCommad.EditDevice;
using DMS.Application.Devices;
using DMS.Application.DevicesQuerry;
using DMS.Application.UserCommand.AddUser;
using DMS.Application.UserCommand.DeleteUser;
using DMS.Application.UserCommand.EditUser;
using DMS.Application.UserQuerry.GetAllUsers;
using MediatR;

namespace DMS.Web
{
    public class DeviceService
    {
        private readonly IMediator _mediator;

        public DeviceService(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<List<DeviceDto>> GetDeviceDtosAsync()
        {
            return await _mediator.Send(new GetDevicesDtoQuerry());
        }
        public async Task<Unit> AddUserAsync(AddUserDto dto)
        {
            var command = new AddUserCommand
            {
                Name = dto.Name,
                Department = dto.Department,
            };
            return await _mediator.Send(command);
        }

        public async Task<Unit> AddDeviceAsync(DeviceDto deviceDto)
        {
            var command = new AddDeviceCommand
            {
                Name = deviceDto.Name,
                SerialNumber = deviceDto.SerialNumber,
                UserName = deviceDto.UserName,
                DayOfPurchase = deviceDto.DayOfPurchase,
                ReleaseDate = deviceDto.ReleseDate,
            };
            return await _mediator.Send(command);
        }
        public Task<bool> DeleteDeviceAsync(string serialNumber)
        {
            return _mediator.Send(new DeleteDeviceCommand { SerialNumber = serialNumber });
        }
        public async Task<List<UserDto>> GetAllUsersAsync()
        {
            return await _mediator.Send(new GetAllUsersQuerry());
        }
        public async Task<bool> DeleteUserAsync(string name)
        {
            return await _mediator.Send(new DeleteUserCommand { Name = name });
        }

        public async Task<Unit> EditUser(EditUserCommand command)
        {
            return await _mediator.Send(command);
        }
        public async Task<Unit> EditDevice(EditDeviceCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}