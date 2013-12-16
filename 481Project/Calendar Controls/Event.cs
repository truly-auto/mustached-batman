using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _481Project.Calendar_Controls
{
    public class Event
    {
        //Data required for an event
        private string date = "";
        public string Date { get { return date; } }
        private string location = "";
        public string Location { get { return location; } }
        private string descritpion = "";
        public string Description { get { return descritpion; } }
        private string event_type = "";
        public string Event_Type { get { return event_type; } }


        public Event(string e, string d, string l, string des) 
        {
            event_type = e;
            date = d;
            location = l;
            descritpion = des;
        }

    }
}
