using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using SimpleTask.Authorization.Roles;
using SimpleTask.Authorization.Users;
using SimpleTask.MultiTenancy;
using SimpleTask.TaskMoulds;

namespace SimpleTask.EntityFramework
{
    public class SimpleTaskDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public SimpleTaskDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in SimpleTaskDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of SimpleTaskDbContext since ABP automatically handles it.
         */
        public SimpleTaskDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public SimpleTaskDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public SimpleTaskDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        public virtual IDbSet<TaskMould> TaskMoulds{ get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ChangeAbpTablePrefix<Tenant, Role, User>(string.Empty);
        }
    }
}
