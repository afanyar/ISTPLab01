using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfGamesMVC.Domain.Entities;

public class Developer : Entity
{
    [MaxLength(50)]
    public required string Name { get; set; }
    [MaxLength(500)]
    public string? Description { get; set; } = "There is no description";

    public ICollection<Game> Games { get; set; } = new List<Game>();
}
