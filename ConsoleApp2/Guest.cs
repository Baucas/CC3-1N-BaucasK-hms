using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3_1N_HMS
{
    public class Guest
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        private List<Reservation> reservations;

        public Guest(string name, string address, string email, int phoneNumber)
        {
            Name = name;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
            reservations = new List<Reservation>();
        }

        public void BookReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }

        public void DisplayReservations()
        {
            Console.WriteLine($"List of Reservations of {Name}:");
            foreach (var reservation in reservations)
            {
                reservation.DisplayDetails();
            }
        }
    }

}
