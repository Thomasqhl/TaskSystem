using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using SimpleTask.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace SimpleTask.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<SimpleTask.EntityFramework.SimpleTaskDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SimpleTask";
        }

        protected override void Seed(SimpleTask.EntityFramework.SimpleTaskDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
