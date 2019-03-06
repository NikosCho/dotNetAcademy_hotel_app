﻿using System;
using System.Collections.Generic;

namespace dotNetAcademy.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public ICollection<Reviews> Reviews { get; set; }
        public ICollection<Favorites> Favorites { get; set; }
        public ICollection<Bookings> Bookings { get; set; }
    }
}
