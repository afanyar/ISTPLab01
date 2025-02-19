using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryOfGamesMVC.Domain.Entities;
using LibraryOfGamesMVC.Infrastructure.EntityConfigurations;

namespace LibraryOfGamesMVC.Infrastructure;

public class LibraryOfGamesContext : DbContext
{
    public LibraryOfGamesContext(DbContextOptions<LibraryOfGamesContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProfileEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new BookmarkEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new GenreEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new DeveloperEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new GameEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new GameAndGenreEntityTypeConfiguration());
    }

}