using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Mangement.DAL.Models;

namespace Task_Mangement.DAL.Configurations
{
    public class ProjectConfigurations : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Description).
                HasMaxLength(500);

            builder.Property(p => p.CreatedAt)
                .IsRequired();

            builder.Property(p => p.OwnerId)
                .IsRequired();
        }
    }
}
