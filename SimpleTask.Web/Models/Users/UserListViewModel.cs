using System.Collections.Generic;
using SimpleTask.Roles.Dto;
using SimpleTask.Users.Dto;

namespace SimpleTask.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}