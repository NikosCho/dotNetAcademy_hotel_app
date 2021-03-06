﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace dotNetAcademy.Models
{
    public partial class Room {
        public int RoomId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string Photo { get; set; }
        public int RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
        public int CountOfGuests { get; set; }
        public int Price { get; set; }
        public string Location { get; set; }
        public string LatLocation { get; set; }
        public string LngLocation { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int Parking { get; set; }
        public int Wifi { get; set; }
        public int PetFriendly { get; set; }

        public ICollection<Reviews> Reviews { get; set; }
        public ICollection<Favorites> Favorites { get; set; }
        public ICollection<Bookings> Bookings { get; set; }
    }
}
