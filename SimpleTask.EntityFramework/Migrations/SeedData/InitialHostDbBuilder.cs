﻿using SimpleTask.EntityFramework;
using EntityFramework.DynamicFilters;

namespace SimpleTask.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly SimpleTaskDbContext _context;

        public InitialHostDbBuilder(SimpleTaskDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
