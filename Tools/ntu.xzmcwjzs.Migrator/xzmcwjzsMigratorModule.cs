using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using ntu.xzmcwjzs.EntityFramework;

namespace ntu.xzmcwjzs.Migrator
{
    [DependsOn(typeof(xzmcwjzsDataModule))]
    public class xzmcwjzsMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<xzmcwjzsDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}