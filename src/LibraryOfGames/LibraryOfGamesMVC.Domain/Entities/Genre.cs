using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfGamesMVC.Domain.Entities
{
    public class Genre : Entity
    {
        [MaxLength(50)]
        public required string Name { get; set; }

        public required ICollection<GamesAndGenresRelationship> GameAndGenreRelationships { get; set; } = new List<GamesAndGenresRelationship>();
    }
}
