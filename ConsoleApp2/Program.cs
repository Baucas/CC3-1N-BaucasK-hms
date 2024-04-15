using System;
using System.Collections.Generic;

namespace CC3_1N_HMS
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<HotelRoom> yananRooms = new List<HotelRoom>();
            HotelRoom room1 = new HotelRoom(101, RoomStyle.TwinRoom, 1500);
            HotelRoom room2 = new HotelRoom(102, RoomStyle.KingRoom, 3000);
            yananRooms.Add(room1);
            yananRooms.Add(room2);
            Hotel hotelYanan = new Hotel("Hotel Yanan", "123 GStreet, Takaw City", yananRooms);

            List<HotelRoom> hotel456Rooms = new List<HotelRoom>();
            HotelRoom hotel456Room1 = new HotelRoom(101, RoomStyle.QueenRoom, 2000);
            HotelRoom hotel456Room2 = new HotelRoom(102, RoomStyle.QueenRoom, 2000);
            hotel456Rooms.Add(hotel456Room1);
            hotel456Rooms.Add(hotel456Room2);
            Hotel hotel456 = new Hotel("Hotel 456", "Session Road, Baguio City", hotel456Rooms);

            HotelManagementSystem hms = new HotelManagementSystem();
            hms.AddHotel(hotelYanan);
            hms.AddHotel(hotel456);


            Console.WriteLine("List of Hotels:");
            hms.DisplayHotels();
            Console.WriteLine();


            Console.WriteLine("Available rooms in Hotel Yanan:");
            hotelYanan.DisplayAvailableRooms();
            Console.WriteLine();

            Guest terry = new Guest("Terry", "Addr 1", "terry@email.com", 63919129);
            hms.RegisterUser(terry);

            hms.BookReservation(hotelYanan, room1, terry, DateTime.Now, new DateTime(2024, 04, 16));


            Console.WriteLine("Booked rooms in Hotel Yanan:");
            hotelYanan.DisplayBookedRooms();
            Console.WriteLine();


            Console.WriteLine($"List of Reservations of {terry.Name}:");
            terry.DisplayReservations();
            Console.WriteLine();

            Receptionist anna = new Receptionist("Anna", "Addr 2", "anna@email.com", 67890);
            hms.RegisterUser(anna);

            Reservation res = new Reservation(new DateTime(2024, 05, 01), new DateTime(2024, 05, 06), hotel456Room2);
            anna.BookReservation(terry, res);

            Console.WriteLine($"Updated list of Reservations of {terry.Name}:");
            terry.DisplayReservations();
            Console.WriteLine();

            Console.WriteLine("Reservation Details for Reservation Number: 1234567890");
            hms.DisplayReservationDetails(1234567890);
        }
    }
}