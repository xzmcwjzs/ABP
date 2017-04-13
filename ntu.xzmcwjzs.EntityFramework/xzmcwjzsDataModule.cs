using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using ntu.xzmcwjzs.EntityFramework;

namespace ntu.xzmcwjzs
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(xzmcwjzsCoreModule))]
    public class xzmcwjzsDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<xzmcwjzsDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
