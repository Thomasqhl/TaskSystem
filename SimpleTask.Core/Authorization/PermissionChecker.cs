using Abp.Authorization;
using SimpleTask.Authorization.Roles;
using SimpleTask.Authorization.Users;

namespace SimpleTask.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
