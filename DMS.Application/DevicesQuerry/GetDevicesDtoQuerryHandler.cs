using AutoMapper;
using DMS.Application.Devices;
using DMS.Domain;
using MediatR;

namespace DMS.Application.DevicesQuerry
{
    public class GetDevicesDtoQuerryHandler : IRequestHandler<GetDevicesDtoQuerry, List<DeviceDto>>
    {

        private readonly IDmsRepository _dmsRepository;
        private readonly IMapper _mapper;

        public GetDevicesDtoQuerryHandler(IDmsRepository dmsRepository, IMapper mapper)
        {
            _dmsRepository = dmsRepository;
            _mapper = mapper;
        }

        public async Task<List<DeviceDto>> Handle(GetDevicesDtoQuerry request, CancellationToken cancellationToken)
        {
            var devices = await _dmsRepository.GetAll();
            var dtos = _mapper.Map<List<DeviceDto>>(devices);
            return dtos;
        }


    }
}