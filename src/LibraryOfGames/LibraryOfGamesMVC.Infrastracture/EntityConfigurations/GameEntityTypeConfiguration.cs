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
    internal class GameEntityTypeConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(game => game.Id);
            builder.Property(game => game.Id).UseIdentityColumn();

            builder.Property(game => game.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(game => game.ImagePath);
            builder.Property(game => game.ImageData);

            builder.Property(game => game.PlayerSupport)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(game => game.Year)
                .IsRequired();

            builder.Property(game => game.Price)
                .IsRequired();

            builder.Property(game => game.Rating)
                .IsRequired();

            builder.Property(game => game.Description)
                .HasMaxLength(500);

            builder.HasOne(game => game.Developer)
                .WithMany(developer => Developer.Games)
                .HasForeignKey(game => game.DeveloperId);

            builder.HasMany(game => game.Bookmarks)
                .WithOne(bookmark => bookmark.Game)
                .HasForeignKey(bookmark => bookmark.GameId);
            builder.HasMany(game => game.GamesAndGenresRelationships)
                .WithOne(gamesAndGenresRelationship => gamesAndGenresRelationship.Game)
                .HasForeignKey(gamesAndGenresRelationship => gamesAndGenresRelationship.GameId);
        }
    }
}
