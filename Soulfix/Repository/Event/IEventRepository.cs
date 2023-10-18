using Soulfix.Models;
using Soulfix.Models.Domain;

namespace Soulfix.Repository.Event
{
    public interface IEventRepository
    {

        EventModel Create(EventModel Event);

        List<EventModel> GetList();

		List<EventModel> GetCategory(int id);

		//Crição de interface par apoder utilziar os métodos dentro de repository
	}
}
