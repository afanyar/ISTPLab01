using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using LibraryOfGamesMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfGamesMVC.Infrastructure.EntityConfigurations
{
    internal class ProfileEntityTypeConfiguration : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.HasKey(profile => profile.Id);
            builder.Property(profile => profile.Id).UseIdentityColumn();

            builder.Property(profile => profile.Login)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(profile => profile.Password)
                .IsRequired()
                .HasMaxLength(8);

            builder.Property(profile => profile.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(profile => profile.Role)
                .IsRequired();
        }
    }
}
