using Microsoft.AspNetCore.Mvc;
using Soulfix.Controllers.Message;
using Soulfix.Metods;
using Soulfix.Models;
using Soulfix.Repository.Category;
using Soulfix.Repository.Event;

namespace Soulfix.Controllers
{
    public class EventController : Controller
    {

        private readonly IEventRepository _eventRepository;
		private readonly ICategoryRepository _categoryRepository;
		private IMessage _msg;

        public EventController(IEventRepository eventRepository, IMessage message, ICategoryRepository categoryRepository)
        {
			_eventRepository = eventRepository;
			_categoryRepository = categoryRepository;
			_msg = message;
        }

		public IActionResult Index()
        {

			List<EventModel> Event = _eventRepository.GetList();
            
			return View(Event);
        }


        public IActionResult Create()
        {
            List<CategoryModel> category = _categoryRepository.GetList();
            TempData["category"] = category;
           
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }






        [HttpPost]
        public IActionResult Create(EventModel EventModel)
        {
            int statusMessage;
            if (ModelState.IsValid)
            {
                _eventRepository.Create(EventModel);
                statusMessage = 0; //succes
                TempData["msg"] = _msg.CreateMessage("Evento", statusMessage);
                TempData["Status"] = statusMessage;
                return RedirectToAction("index");

            }
            statusMessage = 1;
            TempData["msg"] = _msg.CreateMessage("Evento", statusMessage);
            TempData["Status"] = statusMessage;
            return View("Create", EventModel);
        }


        [HttpGet]
        public IActionResult GetForUpdate(int id)
        {
            EventModel Event = _eventRepository.GetForUpdate(id);
            return View("Update", Event);
        }


        [HttpPost]
        public IActionResult Update(EventModel Event)
        {
            _eventRepository.Update(Event);
            return RedirectToAction("index");
        }





        public IActionResult ConfirmDelete(int id)
        {
            EventModel Event = _eventRepository.GetForUpdate(id);
            return View(Event);

        }



        [HttpPost]
        public IActionResult DeleteEvent(EventModel Event)
        {
            EventModel EventDelete = _eventRepository.GetForUpdate(Event.Id);
            _eventRepository.Delete(EventDelete);
            return RedirectToAction("Index");
        }



    }
}
