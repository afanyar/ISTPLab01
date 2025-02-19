using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using LibraryOfGamesMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfGamesMVC.Infrastructure.EntityConfigurations;

internal class GameAndGenreEntityTypeConfiguration : IEntityTypeConfiguration<GameAndGenre>
{
    public void Configure(EntityTypeBuilder<GameAndGenre> builder)
    {
        builder.HasKey(gameAndGenre => gameAndGenre.Id);
        builder.Property(gameAndGenre => gameAndGenre.Id).UseIdentityColumn();

        builder.HasOne(gameAndGenre => gameAndGenre.Genre)
            .WithMany(genre => genre.GameAndGenres)
            .HasForeignKey(gameAndGenre => gameAndGenre.GenreId);

        builder.HasOne(gameAndGenre => gameAndGenre.Game)
            .WithMany(game => game.GameAndGenres)
            .HasForeignKey(gameAndGenre => gameAndGenre.GameId);
    }
}
