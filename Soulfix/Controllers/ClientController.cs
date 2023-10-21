using Microsoft.AspNetCore.Mvc;
using Soulfix.Controllers.Message;
using Soulfix.Models;
using Soulfix.Repository.Client;

namespace Soulfix.Controllers
{
    public class ClientController : Controller
    {
        //OUTRA INJEÇÃO DE DEPENDENCIA PARA PODER USAR MÉTODOS DO REPOSITORIO
        private readonly IClientRepository _clientRepository;
        private IMessage _msg;
        public ClientController(IClientRepository clientRepository, IMessage message)
        {
            _clientRepository = clientRepository;
            _msg = message;
        }

        public IActionResult Index()
        {
            List<ClientModel> Client = _clientRepository.GetList();
            return View(Client);
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(ClientModel clientModel)
        {
            int statusMessage;
            if(ModelState.IsValid)
            {
                _clientRepository.Create(clientModel);
                statusMessage = 0; //succes
                TempData["msg"] = _msg.CreateMessage("Cliente", statusMessage);
                TempData["Status"] = statusMessage;
                return RedirectToAction("index");

            }
            statusMessage = 1;
            TempData["msg"] = _msg.CreateMessage("Cliente", statusMessage);
            TempData["Status"] = statusMessage;
            return View("Create", clientModel);
        }


        [HttpGet]
        public IActionResult GetForUpdate(int id)
        {
            ClientModel client = _clientRepository.GetForUpdate(id);
            return View("Update", client);
        }


        [HttpPost]
        public IActionResult Update(ClientModel client)
        {
            _clientRepository.Update(client);
            return RedirectToAction("index");
        }





        public IActionResult ConfirmDelete(int id)
        {
            ClientModel client = _clientRepository.GetForUpdate(id);
            return View(client);

        }



        [HttpPost]
        public IActionResult DeleteClient(ClientModel client)
        {
            ClientModel clientDelete = _clientRepository.GetForUpdate(client.Id);
            _clientRepository.Delete(clientDelete);
            return RedirectToAction("Index");
        }



    }
}
