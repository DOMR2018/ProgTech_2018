using System.Collections.Generic;

namespace Library.src
{
    public interface IEvents
    {
        void RegisterEvent(Event newEvent);
        List<Event> listEvents();
    }
}
