using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelService.Models
{
    public static class RoomRepository
    {
        public static List<Room> GetRooms()
        {
            return new List<Room>
            {
                new Room{Name="Number for view to ocean"},
                new Room{Name="Single Number"},
                new Room{Name="Number with the pool and cinema"}
            };
        }

    }
}