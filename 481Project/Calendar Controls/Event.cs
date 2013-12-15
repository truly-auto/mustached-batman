using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _481Project.Calendar_Controls
{
    class Event
    {
        //Data required for an event
        private string date = "";
        public string Date { get { return date; } }
        private string location = "";
        public string Location { get { return location; } }
        private string descritpion = "";
        public string Description { get { return descritpion; } }


        public Event(string d, string l, string des) 
        {
            date = d;
            location = l;
            descritpion = des;
        }
    }
}
