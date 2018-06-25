using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using SimpleTask.EntityFramework;

namespace SimpleTask
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(SimpleTaskCoreModule))]
    public class SimpleTaskDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<SimpleTaskDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
