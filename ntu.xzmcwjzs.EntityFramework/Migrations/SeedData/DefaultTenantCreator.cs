using System.Linq;
using ntu.xzmcwjzs.EntityFramework;
using ntu.xzmcwjzs.MultiTenancy;

namespace ntu.xzmcwjzs.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly xzmcwjzsDbContext _context;

        public DefaultTenantCreator(xzmcwjzsDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
