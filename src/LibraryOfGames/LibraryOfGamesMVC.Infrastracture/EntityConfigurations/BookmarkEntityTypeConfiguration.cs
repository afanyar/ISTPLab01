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
    internal class BookmarkEntityTypeConfiguration : IEntityTypeConfiguration<Bookmark>
    {
        public void Configure(EntityTypeBuilder<Bookmark> builder)
        {
            builder.HasKey(bookmark => bookmark.Id);
            builder.Property(bookmark => bookmark.Id).UseIdentityColumn();

            builder.HasOne(bookmark => bookmark.Profile)
                .WithMany(profile => profile.Bookmarks)
                .HasForeignKey(bookmark => bookmark.ProfileId);

            builder.HasOne(bookmark => bookmark.Game)
                .WithMany(game => game.Bookmarks)
                .HasForeignKey(bookmark => bookmark.GameId);
        }
    }
}
