using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using SimpleTask.EntityFramework;

namespace SimpleTask.Migrator
{
    [DependsOn(typeof(SimpleTaskDataModule))]
    public class SimpleTaskMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<SimpleTaskDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}