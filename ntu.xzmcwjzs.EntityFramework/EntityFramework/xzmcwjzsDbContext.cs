using System.Data.Common;
using Abp.Zero.EntityFramework;
using ntu.xzmcwjzs.Authorization.Roles;
using ntu.xzmcwjzs.MultiTenancy;
using ntu.xzmcwjzs.Users;
using System.Data.Entity;
using ntu.xzmcwjzs.Tasks;

namespace ntu.xzmcwjzs.EntityFramework
{
    public class xzmcwjzsDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public xzmcwjzsDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in xzmcwjzsDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of xzmcwjzsDbContext since ABP automatically handles it.
         */
        public xzmcwjzsDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public xzmcwjzsDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public xzmcwjzsDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
        //TODO: Define an IDbSet for your Entities...

        public IDbSet<Task> Tasks { get; set; }
    }
}
