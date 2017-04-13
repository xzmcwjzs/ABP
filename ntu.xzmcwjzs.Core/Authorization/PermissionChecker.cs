using Abp.Authorization;
using ntu.xzmcwjzs.Authorization.Roles;
using ntu.xzmcwjzs.MultiTenancy;
using ntu.xzmcwjzs.Users;

namespace ntu.xzmcwjzs.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
