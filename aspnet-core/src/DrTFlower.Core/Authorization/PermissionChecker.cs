using Abp.Authorization;
using DrTFlower.Authorization.Roles;
using DrTFlower.Authorization.Users;

namespace DrTFlower.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
