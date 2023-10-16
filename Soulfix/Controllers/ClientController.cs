using Microsoft.AspNetCore.Mvc;
using Soulfix.Models;
using Soulfix.Repository.Client;

namespace Soulfix.Controllers
{
    public class ClientController : Controller
    {
        //OUTRA INJEÇÃOD E DEPENDENCIA PARA PODER USAR MÉTODOS DO REPOSITORIO
        private readonly IClientRepository _clientRepository;
        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public IActionResult Index()
        {
           List<ClientModel> Client = _clientRepository.GetList();
            return View(Client);
        }

        [HttpPost]
        public IActionResult Create(ClientModel Client)
        {
            _clientRepository.Create(Client);
            return RedirectToAction("Index");
        }


    }
}
