using Soulfix.Data;
using Soulfix.Models;
using Soulfix.Models.Domain;

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



        public ClientModel Update(ClientModel client)
        {

            ClientModel _client = GetForUpdate(client.Id);

            _client.Name = client.Name;
            _client.Email = client.Email;
            _client.Phone = client.Phone;
            _client.CPF = client.CPF;
            _client.CNPJ = client.CNPJ;

            _baseContext.Client.Update(_client);
            _baseContext.SaveChanges();
            return _client;
        }

        public ClientModel GetForUpdate(int id)
        {
            return _baseContext.Client.FirstOrDefault(x => x.Id == id);

        }

        public ClientModel Delete(ClientModel client)
        {
            _baseContext.Client.Remove(client);
            _baseContext.SaveChanges();
            return client;
        }


    }
}
