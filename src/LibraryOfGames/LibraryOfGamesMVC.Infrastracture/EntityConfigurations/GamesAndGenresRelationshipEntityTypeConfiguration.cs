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
    internal class GamesAndGenresRelationshipEntityTypeConfiguration : IEntityTypeConfiguration<GamesAndGenresRelationship>
    {
        public void Configure(EntityTypeBuilder<GamesAndGenresRelationship> builder)
        {
            builder.HasKey(gamesAndGenresRelationship => gamesAndGenresRelationship.Id);
            builder.Property(gamesAndGenresRelationship => gamesAndGenresRelationship.Id).UseIdentityColumn();

            builder.HasOne(gamesAndGenresRelationship => gamesAndGenresRelationship.Genre)
                .WithMany(genre => genre.GamesAndGenresRelationship)
                .HasForeignKey(gamesAndGenresRelationship => gamesAndGenresRelationship.GenreId);

            builder.HasOne(gamesAndGenresRelationship => gamesAndGenresRelationship.Game)
                .WithMany(game => game.GamesAndGenresRelationship)
                .HasForeignKey(gamesAndGenresRelationship => gamesAndGenresRelationship.GameId);
        }
    }
}
