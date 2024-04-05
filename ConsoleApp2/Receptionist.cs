using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3_1N_HMS
{
    public class Receptionist: User
    {
        public Receptionist(string name, string address, string email, int phoneNumber) : base(name, address, email, phoneNumber)
        {
        }

        public void BookReservation(Hotel hotel, HotelRoom room, User user)
        {
            Reservation reservation = new Reservation
            {
                ReservationNumber = Guid.NewGuid().ToString(),
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(3),
                DurationInDays = 3,
                User = user,
                HotelRoom = room,
                Hotel = hotel
            };

            reservation.DisplayReservationDetails();
            Console.WriteLine("Reservation created successfully!");
        }
    }
}
