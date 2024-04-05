using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3_1N_HMS
{
    public class Reservation
    {
        public int ReservationNumber { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public HotelRoom Room { get; set; }
        public int DurationInDays { get; set; }
        public decimal Total { get; set; }

        public Reservation(DateTime startTime, DateTime endTime, HotelRoom room)
        {
            ReservationNumber = GenerateReservationNumber();
            StartTime = startTime;
            EndTime = endTime;
            Room = room;
            DurationInDays = (int)(endTime - startTime).TotalDays;
            Total = DurationInDays * room.BookingPrice;
        }

        private int GenerateReservationNumber()
        {
            Random random = new Random();
            return random.Next(100000000, 999999999);
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Reservation Number: {ReservationNumber}");
            Console.WriteLine($"Start Time: {StartTime}");
            Console.WriteLine($"End Time: {EndTime}");
            Console.WriteLine($"Duration: {DurationInDays} days");
            Console.WriteLine($"Total: {Total}");
        }
    }
}
