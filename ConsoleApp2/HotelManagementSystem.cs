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
        private List<UserAccount> users;

        public HotelManagementSystem()
        {
            hotels = new List<Hotel>();
            users = new List<UserAccount>();
        }

        public void AddHotel(Hotel hotel)
        {
            hotels.Add(hotel);
        }

        public void RegisterUser(UserAccount user)
        {
            users.Add(user);
        }

        public void BookReservation(Hotel hotel, HotelRoom room, Guest guest, DateTime startTime, DateTime endTime)
        {
            Reservation reservation = new Reservation
            {
                ReservationNumber = Guid.NewGuid().ToString(),
                StartTime = startTime,
                EndTime = endTime,
                DurationInDays = (endTime - startTime).Days,
                User = guest,
                HotelRoom = room,
                Hotel = hotel
            };

            guest.BookRoom(room);
            room.IsAvailable = false;
            Console.WriteLine("Reservation booked successfully!");
        }

        public void DisplayHotels()
        {
            foreach (Hotel hotel in hotels)
            {
                hotel.DisplayHotelInfo();
            }
        }

        public void DisplayReservationDetails(string reservationNumber)
        {
            foreach (Hotel hotel in hotels)
            {
                foreach (HotelRoom room in hotel.Rooms)
                {
                    if (room.IsAvailable == false)
                    {
                        Console.WriteLine($"Hotel: {hotel.Name}, Room: {room.RoomNumber}, Reservation Number: {reservationNumber}");
                    }
                }
            }
        }
    }
}

