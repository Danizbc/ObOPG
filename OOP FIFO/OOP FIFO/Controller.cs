using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FIFO
{
    class Controller
    {
        Queue<Guest> guestQueue = new Queue<Guest>();

        Queue<Guest> guestInside = new Queue<Guest>();
        
        Guest guest;

        
        //Constructor
        public Controller()
        {
            guestQueue.Enqueue(guest = new Guest("Bente", 18));
            guestQueue.Enqueue(guest = new Guest("Karla", 20));
            guestQueue.Enqueue(guest = new Guest("Åge", 22));
            guestQueue.Enqueue(guest = new Guest("Bente", 22));
        }

        //Methods

            //print out guest queue
        public string PrintGuestList()
        {
            string guestTemp = "";
            guestTemp += "Guest List\n\n";
            foreach (Guest guests in guestQueue)
            {
                guestTemp += $"Name = {guests.Name}\nAge = {guests.Age}\n\n";
            }

            return guestTemp;
        }

        public string LetOneGuestIn()
        {
            string GuestQue = $"Letting {guestQueue.Peek().Name} age {guestQueue.Peek().Age} into the club";
           guestInside.Enqueue(guestQueue.Dequeue());

            return GuestQue;
        }

        public string PrintGuestInside()
        {
            string partying = "";
            partying += "People inside the party\n\n";
            foreach (Guest Aguest in guestInside)
            {
                partying += $"Name = {Aguest.Name}.\nAge = {Aguest.Age}.\n\n";

            }

            return partying;
        }

        public string KickFirstGuest()
        {
            string Kicked = $"You kicked {guestInside.Peek().Name} out.";
            guestInside.Dequeue();
            return Kicked;
        }


    }
}
