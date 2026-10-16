using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Mangement.DAL.Models;

namespace Task_Mangement.DAL.DbContexts
{
    public class TaskDbContext:DbContext
    {
        #region DbSets
        public DbSet<Project> Projects { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        #endregion
        public TaskDbContext(DbContextOptions<TaskDbContext> options)
       : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TaskDbContext).Assembly);
        }
    }
}
