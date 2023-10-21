using Soulfix.Models;
using Soulfix.Models.Domain;

namespace Soulfix.Repository.User
{
    public interface IUserRepository
    {

        UserModel Create(UserModel User);

        UserModel GetForUpdate(int id);
        UserModel Update(UserModel User);

        UserModel Delete(UserModel User);

        List<UserModel> GetList();

        //Crição de interface para poder utilziar os métodos dentro de repository
    }
}
