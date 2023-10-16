using Soulfix.Models;
using Soulfix.Models.Domain;

namespace Soulfix.Repository.Client
{
    public interface IClientRepository
    {

        ClientModel Create(ClientModel Client);

        List<ClientModel> GetList();   

        //Crição de interface par apoder utilziar os métodos dentro de repository
    }
}
