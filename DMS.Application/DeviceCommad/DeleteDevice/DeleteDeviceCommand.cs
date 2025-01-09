using DMS.Application.DeviceCommad.AddDevice;
using MediatR;

namespace DMS.Application.DeviceCommad.DeleteDevice
{
    public class DeleteDeviceCommand : AddDeviceDto, IRequest<bool>
    {

    }
}
