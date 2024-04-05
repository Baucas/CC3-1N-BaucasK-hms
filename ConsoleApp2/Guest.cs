using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3_1N_HMS
{
    public class Guest: User
    {
        public int TotalRoomsBooked { get; set; }

        public Guest(string name, string address, string email, int phoneNumber) : base(name, address, email, phoneNumber)
        {
            TotalRoomsBooked = 0;
        }

        public void BookRoom(HotelRoom room)
        {
            room.IsAvailable = false;
            TotalRoomsBooked++;
            Console.WriteLine("Room booked successfully!");
        }
    }
}
