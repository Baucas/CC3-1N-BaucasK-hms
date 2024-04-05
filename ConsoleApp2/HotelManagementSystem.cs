using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3_1N_HMS
{
    public class HotelManagementSystem
    {
        private List<Hotel> hotels;
        private List<Guest> users;
        private List<Reservation> reservations;

        public HotelManagementSystem()
        {
            hotels = new List<Hotel>();
            users = new List<Guest>();
            reservations = new List<Reservation>();
        }

        public void RegisterUser(Guest user)
        {
            users.Add(user);
        }

        public void AddHotel(Hotel hotel)
        {
            hotels.Add(hotel);
        }

        public void DisplayHotels()
        {
            Console.WriteLine("List of Hotels:");
            foreach (var hotel in hotels)
            {
                Console.WriteLine($"{hotel.HotelName}, {hotel.Location}");
            }
        }

        public void BookReservation(Hotel hotel, HotelRoom room, Guest guest, DateTime startTime, DateTime endTime)
        {
            if (!room.Status)
            {
                Console.WriteLine("Room is already booked.");
                return;
            }

            room.Status = false;
            Reservation reservation = new Reservation(startTime, endTime, room);
            reservations.Add(reservation);
            guest.BookReservation(reservation);
        }

        public void DisplayReservationDetails(int reservationNumber)
        {
            var reservation = reservations.Find(r => r.ReservationNumber == reservationNumber);
            if (reservation == null)
            {
                Console.WriteLine("Reservation not found.");
                return;
            }

            reservation.DisplayDetails();
        }
    }

}


