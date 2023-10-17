using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Soulfix.Data;
using Soulfix.Models;
using Soulfix.Repository.Event;

namespace Soulfix.Repository.Event
{
    public class EventRepository : IEventRepository
    {

        private readonly BaseContext _baseContext;

        public EventRepository(BaseContext baseContext)
        {
            _baseContext = baseContext; 
        }

        public List<EventModel> GetList()
        {
           return _baseContext.Event.ToList();
        }
        public EventModel Create(EventModel eventParam)
        {
            _baseContext.Event.Add(eventParam);
            _baseContext.SaveChanges(); 
            return eventParam;
        }

    }
}
