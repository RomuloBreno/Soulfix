using Soulfix.Models;
using Soulfix.Models.Domain;

namespace Soulfix.Repository.User
{
    public interface IUserRepository
    {

        UserModel Create(UserModel User);

        List<UserModel> GetList();

        //Crição de interface par apoder utilziar os métodos dentro de repository
    }
}
