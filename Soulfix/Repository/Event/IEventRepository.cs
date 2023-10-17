using Soulfix.Models;
using Soulfix.Models.Domain;

namespace Soulfix.Repository.Event
{
    public interface IEventRepository
    {

        EventModel Create(EventModel User);

        List<EventModel> GetList();

        //Crição de interface par apoder utilziar os métodos dentro de repository
    }
}
