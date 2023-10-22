using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
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
            return _baseContext.Event.Include(x => x.Category).ToList();
		}
        public EventModel Create(EventModel eventParam)
        {
            _baseContext.Event.Add(eventParam);
            _baseContext.SaveChanges(); 
            return eventParam;
        }




        public EventModel Update(EventModel eventParam)
        {

            EventModel _event = GetForUpdate(eventParam.Id);

            _event.Name = eventParam.Name;
            _event.Description = eventParam.Description;
            _event.Date = eventParam.Date;
            _event.CategoryId = eventParam.CategoryId;
           

            _baseContext.Event.Update(_event);
            _baseContext.SaveChanges();
            return _event;
        }

        public EventModel GetForUpdate(int id)
        {
            return _baseContext.Event.FirstOrDefault(x => x.Id == id);

        }

        public EventModel Delete(EventModel eventParam)
        {
            _baseContext.Event.Remove(eventParam);
            _baseContext.SaveChanges();
            return eventParam;
        }



    }
}
