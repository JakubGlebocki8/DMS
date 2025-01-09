using AutoMapper;
using DMS.Application.UserCommand.AddUser;
using DMS.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Application.UserCommand.EditUser
{
    public class EditUserCommandHandler : IRequestHandler<EditUserCommand>
    {
        private IDmsRepository _repository;
        public EditUserCommandHandler(IDmsRepository repository,IMapper mapper)
        {
            _repository = repository;
        }
        public async Task<Unit> Handle(EditUserCommand request, CancellationToken cancellationToken)
        {
           var user = await _repository.GetUserByNameAsync(request.Name);
            if (user != null) {
                user.Department = request.department;
            }
            await _repository.Commit();
            return Unit.Value;

        }
    }
}
