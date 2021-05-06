﻿using Acme.ProjectCompare.Model;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.ProjectCompare.EntityFrameworkCore
{
    [ConnectionStringName(ProjectCompareDbProperties.ConnectionStringName)]
    public class ProjectCompareDbContext : AbpDbContext<ProjectCompareDbContext>, IProjectCompareDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public ProjectCompareDbContext(DbContextOptions<ProjectCompareDbContext> options) 
            : base(options)
        {

        }
        public virtual DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureProjectCompare();
        }
    }
}