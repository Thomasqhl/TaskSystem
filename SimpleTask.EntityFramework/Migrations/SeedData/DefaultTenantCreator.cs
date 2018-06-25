using System.Linq;
using SimpleTask.EntityFramework;
using SimpleTask.MultiTenancy;

namespace SimpleTask.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly SimpleTaskDbContext _context;

        public DefaultTenantCreator(SimpleTaskDbContext context)
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
