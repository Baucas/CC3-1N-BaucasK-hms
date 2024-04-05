using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3_1N_HMS
{
    public class Hotel
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public List<HotelRoom> Rooms { get; set; }

        public void DisplayAvailableRooms()
        {
            Console.WriteLine($"Available rooms in {Name} - {Location}:");
            foreach (HotelRoom room in Rooms)
            {
                if (room.IsAvailable)
                {
                    room.DisplayRoomDetails();
                    Console.WriteLine();
                }
            }
        }

        public void BookRoom(Guest guest, string roomNumber)
        {
            HotelRoom room = Rooms.Find(r => r.RoomNumber.Equals(roomNumber, StringComparison.OrdinalIgnoreCase));

            if (room != null)
            {
                room.BookRoom(guest);
            }
            else
            {
                Console.WriteLine("Invalid room number.");
            }
        }

        public void DisplayBookedRooms()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Location: {Location}");
        }
    }
}
