using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Soulfix.Models;
using Soulfix.Models.Domain;
using Soulfix.Repository.Category;
using Soulfix.Repository.Event;
using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Soulfix.Controllers
{
    public class CalendarController : Controller
	{
		private readonly IEventRepository _eventRepository;
		private readonly ICategoryRepository _categoryRepository;

		public  int _monthChange;


		public CalendarController(IEventRepository eventRepository, ICategoryRepository categoryRepository)
		{
			_eventRepository = eventRepository;
			_categoryRepository = categoryRepository;

		}
		public IActionResult Index(int monthChange)
		{
			List<EventModel> Event = _eventRepository.GetList();
			EventCalendarCoupleModel eventCalendarCoupleModel = new EventCalendarCoupleModel()
			{
				Event = Event,
				_monthChange = Month(monthChange),
			};

			return View(eventCalendarCoupleModel);
		}

		public int Month(int monthChange)
		{
			return _monthChange = monthChange;
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}