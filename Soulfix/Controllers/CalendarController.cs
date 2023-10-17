using Microsoft.AspNetCore.Mvc;
using Soulfix.Models;
using Soulfix.Repository.Event;
using System.Diagnostics;

namespace Soulfix.Controllers
{
    public class CalendarController : Controller
    {
		private readonly IEventRepository _eventRepository;
		public CalendarController(IEventRepository eventRepository)
		{
			_eventRepository = eventRepository;
		}

		public IActionResult Index()
		{
			List<EventModel> Event = _eventRepository.GetList();
			return View(Event);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}