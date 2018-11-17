﻿using System.Collections.Generic;

namespace Library.src
{
    public class Events : IEvents
    {
        private List<Event> allEvents = new List<Event>();

        public List<Event> listEvents()
        {
            return allEvents;
        }

        public void RegisterEvent(Event newEvent)
        {
            allEvents.Add(newEvent);
        }
    }
}
