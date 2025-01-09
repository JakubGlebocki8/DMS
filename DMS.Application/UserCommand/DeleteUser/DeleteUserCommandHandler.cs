using DMS.Domain;
using MediatR;

namespace DMS.Application.UserCommand.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, bool>
    {
        IDmsRepository _repository;
        public DeleteUserCommandHandler(IDmsRepository repository)
        {
            _repository = repository;
        }
        public Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            return _repository.DeleteUserByName(request.Name);
        }
    }
}
