using Microsoft.AspNetCore.Mvc;
using Soulfix.Metods;
using Soulfix.Models;
using Soulfix.Repository.Event;

namespace Soulfix.Controllers
{
    public class EventController : Controller
    {

        private readonly IEventRepository _eventRepository;

        public EventController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

		public IActionResult Index()
        {

			List<EventModel> Event = _eventRepository.GetList();
            return View(Event);
        }
    }
}
