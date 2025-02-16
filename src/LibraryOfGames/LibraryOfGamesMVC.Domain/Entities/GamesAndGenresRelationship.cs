using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfGamesMVC.Domain.Entities
{
    public class GamesAndGenresRelationship : Entity, IAggregateRoot
    {
        public int GameID { get; set; }
        public Game? Game { get; set; }

        public int GenreID { get; set; }
        public Genre? Genre { get; set; }
    }
}
