using AutoMapper;
using DMS.Domain;
using MediatR;

namespace DMS.Application.UserCommand.AddUser
{
    public class AddUserCommandHandler : IRequestHandler<AddUserCommand>
    {
        IDmsRepository _repository;
        IMapper _mapper;
        public AddUserCommandHandler(IDmsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }
        public Task<Unit> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<User>(request);
            _repository.CreateUser(dto);
            return Unit.Task;
        }
    }
}
