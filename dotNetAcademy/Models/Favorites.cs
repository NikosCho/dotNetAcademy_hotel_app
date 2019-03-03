﻿using System;
using System.Collections.Generic;

namespace dotNetAcademy.Models
{
    public partial class Favorites
    {
        public int FavoriteId { get; set; }
        public DateTime DateCreated { get; set; }
        public int Status { get; set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }

        public User User{ get; set; }
    }
}
