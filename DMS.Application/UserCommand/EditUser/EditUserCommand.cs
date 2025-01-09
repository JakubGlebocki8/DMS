using DMS.Application.UserCommand.AddUser;
using DMS.Application.UserQuerry.GetAllUsers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Application.UserCommand.EditUser
{
    public class EditUserCommand : UserDto , IRequest
    {

    }
}
