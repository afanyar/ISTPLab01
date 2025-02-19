using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfGamesMVC.Domain.Entities;

public class Game : Entity, IAggregateRoot
{
    [MaxLength(100)]
    public required string Name { get; set; }

    public string? ImagePath { get; set; } = "There is no image";
    public byte[]? ImageData { get; set; }
    [MaxLength(50)]
    public required string PlayerSupport { get; set; }
    public required int Year { get; set; }

    [Range(0, int.MaxValue)]
    public int Price { get; set; }

    [Range(1, 10)]
    public int Rating { get; set; }

    [MaxLength(100)]
    public string? Description { get; set; } = "There is no description";

    public int DeveloperId { get; set; }
    public Developer? Developer { get; set; }
    public required ICollection<GameAndGenre> GameAndGenres { get; set; } = new List<GameAndGenre>();
    public required ICollection<Bookmark> Bookmarks { get; set; } = new List<Bookmark>();
}
