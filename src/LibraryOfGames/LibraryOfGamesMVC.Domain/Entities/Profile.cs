using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfGamesMVC.Domain.Entities
{
    public class Profile : Entity
    {
        public enum ProfileRole
        {
            Editor,
            User
        }

        [MaxLength(30)]
        public required string Login { get; set; }
        [MaxLength(8)]
        public required string Password { get; set; }
        [MaxLength(50)]
        public required string Email { get; set; }

        public ProfileRole Role { get; set; } = ProfileRole.User;

        public required ICollection<Bookmark> Bookmarks { get; set; } = new List<Bookmark>();

    }
}
