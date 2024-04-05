using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3_1N_HMS
{
    public class Reservation
    {
        public string ReservationNumber { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int DurationInDays { get; set; }
        public User User { get; set; }
        public HotelRoom HotelRoom { get; set; }
        public Hotel Hotel { get; set; }

        public void DisplayReservationDetails()
        {
            Console.WriteLine($"Reservation Number: {ReservationNumber}");
            Console.WriteLine($"Start Time: {StartTime}");
            Console.WriteLine($"End Time: {EndTime}");
            Console.WriteLine($"Duration: {DurationInDays} days");
            Console.WriteLine($"User: {User.Name}");
            Console.WriteLine($"Room: {HotelRoom.RoomNumber}");
            Console.WriteLine($"Hotel: {Hotel.Name} - {Hotel.Location}");
        }

        public void BookRoom()
        {
            if (HotelRoom.IsAvailable)
            {
                HotelRoom.IsAvailable = false;
                Console.WriteLine("Room booked successfully!");
            }
            else
            {
                Console.WriteLine("Room is not available.");
            }
        }
    }
}
