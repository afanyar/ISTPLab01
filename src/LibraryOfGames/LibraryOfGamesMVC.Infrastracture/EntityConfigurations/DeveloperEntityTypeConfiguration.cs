using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using LibraryOfGamesMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfGamesMVC.Infrastracture.EntityConfigurations
{
    internal class DeveloperEntityTypeConfiguration : IEntityTypeConfiguration<Developer>
    {
        public void Configure(EntityTypeBuilder<Developer> builder)
        {
            builder.HasKey(developer => developer.Id);
            builder.Property(developer => developer.Id).UseIdentityColumn();

            builder.Property(developer => developer.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(developer => developer.Description)
                .HasMaxLength(500);
        }
    }
}
