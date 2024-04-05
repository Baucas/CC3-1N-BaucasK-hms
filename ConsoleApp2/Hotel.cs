using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3_1N_HMS
{
    public class Hotel
    {
        public string HotelName { get; set; }
        public string Location { get; set; }
        private List<HotelRoom> allRooms;

        public Hotel(string hotelName, string location, List<HotelRoom> rooms)
        {
            HotelName = hotelName;
            Location = location;
            allRooms = rooms;
        }

        public void DisplayAvailableRooms()
        {
            Console.WriteLine($"Hotel {HotelName} - Available Rooms:");
            foreach (var room in allRooms)
            {
                if (room.Status)
                {
                    Console.WriteLine($"Room {room.RoomNumber}, Style: {room.Style}, Price: {room.BookingPrice}");
                }
            }
        }

        public void DisplayBookedRooms()
        {
            Console.WriteLine($"Hotel {HotelName} - Booked Rooms:");
            foreach (var room in allRooms)
            {
                if (!room.Status)
                {
                    Console.WriteLine($"Room {room.RoomNumber}, Style: {room.Style}, Price: {room.BookingPrice}");
                }
            }
        }
    }

}
