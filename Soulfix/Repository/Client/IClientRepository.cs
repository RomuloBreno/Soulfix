using Soulfix.Models;
using Soulfix.Models.Domain;

namespace Soulfix.Repository.Client
{
    public interface IClientRepository
    {

        ClientModel Create(ClientModel Client);

        ClientModel GetForUpdate(int id);

        ClientModel Update(ClientModel client);

        ClientModel Delete(ClientModel client);

        List<ClientModel> GetList();   

        //Crição de interface par apoder utilziar os métodos dentro de repository
    }
}
