using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3_1N_HMS
{
    
    public class HotelRoom
    {
        public string RoomNumber { get; set; }
        public RoomStyle Style { get; set; }
        public bool IsAvailable { get; set; }
        public decimal BookingPrice { get; set; }

        public void DisplayRoomDetails()
        {
            Console.WriteLine($"Room Number: {RoomNumber}");
            Console.WriteLine($"Style: {Style}");
            Console.WriteLine($"Is Available: {IsAvailable}");
            Console.WriteLine($"Booking Price: {BookingPrice}");
        }

        public void BookRoom(Guest guest)
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                guest.BookRoom(this);
            }
            else
            {
                Console.WriteLine("Room is not available.");
            }
        }
    }
}
