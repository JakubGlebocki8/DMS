using DMS.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Application.DeviceCommad.EditDevice
{
    public class EditDeviceCommandHandler : IRequestHandler<EditDeviceCommand>
    {
        IDmsRepository _repository;
        public EditDeviceCommandHandler(IDmsRepository dmsRepository)
        {
            _repository = dmsRepository;
        }
        public async Task<Unit> Handle(EditDeviceCommand request, CancellationToken cancellationToken)
        {
            var device = await _repository.GetDeviceBySerialNumberAsync(request.SerialNumber);
            if (device == null)
            {
                throw new Exception("Device not found");
            }
            if (!string.IsNullOrEmpty(request.UserName))
            {
                var user = await _repository.GetUserByNameAsync(request.UserName);
                if (user == null)
                {
                    throw new Exception($"User with name '{request.UserName}' not found");
                }
                device.User = user;
            }
            else
            {
                device.User = null;
            }
            device.Name = request.Name;
            device.DayOfPurchase = request.DayOfPurchase;
            device.ReleaseDate = request.ReleseDate;
            device.DayOfPurchase = request?.DayOfPurchase;
            await _repository.Commit();
            return Unit.Value;


        }
    }
}
