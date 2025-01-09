using DMS.Application.UserCommand.AddUser;
using MediatR;

namespace DMS.Application.UserCommand.DeleteUser
{
    public class DeleteUserCommand : AddUserDto, IRequest<bool>
    {

    }
}
