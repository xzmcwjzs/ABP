using Abp.MultiTenancy;
using ntu.xzmcwjzs.Users;

namespace ntu.xzmcwjzs.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}