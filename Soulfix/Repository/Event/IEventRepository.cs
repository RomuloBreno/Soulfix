using Soulfix.Models;
using Soulfix.Models.Domain;

namespace Soulfix.Repository.Event
{
    public interface IEventRepository
    {

        EventModel Create(EventModel eventParam);

        List<EventModel> GetList();

        EventModel GetForUpdate(int id);

        EventModel Update(EventModel eventParam);

        EventModel Delete(EventModel eventParam);


        List<EventModel> GetCategory(int id);

		//Crição de interface par apoder utilziar os métodos dentro de repository
	}
}
