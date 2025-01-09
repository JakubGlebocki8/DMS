using DMS.Application.Devices;
using MediatR;

namespace DMS.Application.DevicesQuerry;
public class GetDevicesDtoQuerry : IRequest<List<DeviceDto>>
{
}