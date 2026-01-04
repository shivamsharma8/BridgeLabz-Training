using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.constructors
{
    public class HotelBooking
    {
        public string guestName;
        public string roomType;
        public int nights;
        //parameterized
        public HotelBooking(string guestName, string roomType, int nights)
        {
            this.guestName = guestName;
            this.roomType = roomType;
            this.nights = nights;
        }
        //default constructor
        public HotelBooking() {
            guestName = "Loveeesh";
            roomType = "Double";
            nights = 2;
        }
        //copy constructor
        public HotelBooking(HotelBooking booking)
        {
            this.guestName = booking.guestName;
            this.roomType = booking.roomType;
            this.nights = booking.nights;

        }
        void DisplayDetails()
        {
            Console.WriteLine("Hotel Booking ");
            Console.WriteLine("Guest Name "+ guestName);
            Console.WriteLine("Type of room "+ roomType);
            Console.WriteLine("Number of nights "+nights);
        }
        static void Main(string[] args)
        {
            HotelBooking booking1 = new HotelBooking("Dev", "twin beds", 4);//parameterized calling
            HotelBooking booking2 = new HotelBooking();//default
            HotelBooking booking3 = new HotelBooking("Ris","King size", 5);//copy

            booking1.DisplayDetails();
            booking2.DisplayDetails();
            booking3.DisplayDetails();
        }

    }
}
