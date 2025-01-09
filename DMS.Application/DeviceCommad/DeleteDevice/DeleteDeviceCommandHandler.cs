using DMS.Domain;
using MediatR;

namespace DMS.Application.DeviceCommad.DeleteDevice
{
    public class DeleteDeviceCommandHandler : IRequestHandler<DeleteDeviceCommand, bool>
    {
        private IDmsRepository _repository;
        public DeleteDeviceCommandHandler(IDmsRepository repository)
        {
            _repository = repository;
        }
        public Task<bool> Handle(DeleteDeviceCommand request, CancellationToken cancellationToken)
        {
            return _repository.DeleteDeviceBySerialNumber(request.SerialNumber);
        }
    }
}
