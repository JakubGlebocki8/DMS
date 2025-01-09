using MediatR;

namespace DMS.Application.UserQuerry.GetAllUsers
{
    public class GetAllUsersQuerry : IRequest<List<UserDto>>
    {
    }
}
