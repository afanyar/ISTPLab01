﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfGamesMVC.Domain.Entities;

public class Bookmark : Entity, IAggregateRoot
{
    public int ProfileId { get; set; }
    public Profile? Profile { get; set; }

    public int GameId { get; set; }
    public Game? Game { get; set; }
}
