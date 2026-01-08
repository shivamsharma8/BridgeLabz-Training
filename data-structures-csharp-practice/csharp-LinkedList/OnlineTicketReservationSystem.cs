using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.LinkedList
{
    class TicketNode
    {
        public int TicketId;
        public string CustomerName;
        public string MovieName;
        public int SeatNumber;
        public DateTime BookingTime;

        public TicketNode Next;

        public TicketNode(int id, string customer, string movie, int seat)
        {
            TicketId = id;
            CustomerName = customer;
            MovieName = movie;
            SeatNumber = seat;
            BookingTime = DateTime.Now;
            Next = null;
        }
    }

    class TicketCircularLinkedList
    {
        private TicketNode head;
        private TicketNode tail;

        public void AddTicket(int id, string customer, string movie, int seat)
        {
            TicketNode newTicket = new TicketNode(id, customer, movie, seat);

            if (head == null)
            {
                head = tail = newTicket;
                newTicket.Next = head;
                return;
            }

            tail.Next = newTicket;
            newTicket.Next = head;
            tail = newTicket;
        }

        public void RemoveTicket(int id)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked.");
                return;
            }

            TicketNode current = head;
            TicketNode previous = tail;

            do
            {
                if (current.TicketId == id)
                {
                    if (current == head && current == tail)
                    {
                        head = tail = null;
                    }
                    else if (current == head)
                    {
                        head = head.Next;
                        tail.Next = head;
                    }
                    else if (current == tail)
                    {
                        tail = previous;
                        tail.Next = head;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }

                    Console.WriteLine("Ticket cancelled successfully.");
                    return;
                }

                previous = current;
                current = current.Next;

            } while (current != head);

            Console.WriteLine("Ticket not found.");
        }

        public void DisplayTickets()
        {
            if (head == null)
            {
                Console.WriteLine("No tickets to display.");
                return;
            }

            TicketNode temporaryTransversal = head;
            do
            {
                DisplayTicket(temporaryTransversal);
                temporaryTransversal = temporaryTransversal.Next;
            }
            while (temporaryTransversal != head);
        }

        public void SearchTicket(string keyword)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked.");
                return;
            }

            TicketNode temporaryTransversal = head;
            bool found = false;

            do
            {
                if (temporaryTransversal.CustomerName.Equals(keyword, StringComparison.OrdinalIgnoreCase) ||
                    temporaryTransversal.MovieName.Equals(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayTicket(temporaryTransversal);
                    found = true;
                }
                temporaryTransversal = temporaryTransversal.Next;
            }
            while (temporaryTransversal != head);

            if (!found)
                Console.WriteLine("No matching ticket found.");
        }

        public void CountTickets()
        {
            if (head == null)
            {
                Console.WriteLine("Total Tickets: 0");
                return;
            }

            int count = 0;
            TicketNode temporaryTransversal = head;

            do
            {
                count++;
                temporaryTransversal = temporaryTransversal.Next;
            }
            while (temporaryTransversal != head);

            Console.WriteLine("Total Tickets Booked: " + count);
        }

        private void DisplayTicket(TicketNode ticket)
        {
            Console.WriteLine(
                $"TicketID: {ticket.TicketId} | Customer: {ticket.CustomerName} | + Movie: {ticket.MovieName} | Seat: {ticket.SeatNumber} | + Time: {ticket.BookingTime}");
        }
    }

    class OnlineTicketReservationSystem
    {
        static void Main(string[] args){
            TicketCircularLinkedList tickets = new TicketCircularLinkedList();

            tickets.AddTicket(101, "Rama", "Inception", 12);
            tickets.AddTicket(102, "Priyanshu", "Avatar", 15);
            tickets.AddTicket(103, "Dev", "Inception", 18);

            Console.WriteLine(" Current Tickets:");
            tickets.DisplayTickets();

            Console.WriteLine(" Search by Movie Name:");
            tickets.SearchTicket("Inception");

            Console.WriteLine("Cancel Ticket 102:");
            tickets.RemoveTicket(102);

            Console.WriteLine(" Updated Tickets:");
            tickets.DisplayTickets();

            Console.WriteLine(" Ticket Count:");
            tickets.CountTickets();
        }
    }
}
