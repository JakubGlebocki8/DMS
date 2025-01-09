using AutoMapper;
using DMS.Domain;
using MediatR;

namespace DMS.Application.DeviceCommad.AddDevice
{
    public class AddDeviceCommandHandler : IRequestHandler<AddDeviceCommand>
    {
        private readonly IMapper _mapper;
        private readonly IDmsRepository _repository;

        public AddDeviceCommandHandler(IMapper mapper, IDmsRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<Unit> Handle(AddDeviceCommand request, CancellationToken cancellationToken)
        {
            var user = await _repository.GetUserByNameAsync(request.UserName);

            
            var device = _mapper.Map<Device>(request);
            if (user == null)
            {
                device.UserId = null;
            }
            else
            {
                device.UserId = user.Id;
            }
            await _repository.Create(device);
            return Unit.Value;
        }
    }
}
