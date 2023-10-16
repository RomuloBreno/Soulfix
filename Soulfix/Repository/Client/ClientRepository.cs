using Soulfix.Data;
using Soulfix.Models;

namespace Soulfix.Repository.Client
{
    public class ClientRepository : IClientRepository
    {


        //Injeção do contexto do banco via construtor dentro do repositorio para fazer CRUD

        private readonly BaseContext _baseContext;
        public ClientRepository(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }



        public ClientModel Create(ClientModel Client)
        {
            _baseContext.Client.Add(Client);
            _baseContext.SaveChanges();
            return Client;
        }


        public List<ClientModel> GetList()
        {
            return _baseContext.Client.ToList();
        }
    }
}
