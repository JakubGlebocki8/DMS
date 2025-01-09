using AutoMapper;
using DMS.Domain;
using MediatR;

namespace DMS.Application.UserQuerry.GetAllUsers
{
    public class GetAllUsersQuerryHandler : IRequestHandler<GetAllUsersQuerry, List<UserDto>>
    {
        private IDmsRepository _repository;
        private IMapper _mapper;
        public GetAllUsersQuerryHandler(IDmsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<UserDto>> Handle(GetAllUsersQuerry request, CancellationToken cancellationToken)
        {
            var users = await _repository.GetAllUsers();
            var dtos = _mapper.Map<List<UserDto>>(users);
            foreach (var d in dtos)
            {
                var deviceCount = await _repository.CountDevice(d.Name);
                d.CountOfDevices = deviceCount;
            }
            return dtos;
        }
    }
}
