using Soulfix.Controllers;
using Soulfix.Models;
using Soulfix.Models.Domain;

namespace Soulfix.Repository.Login
{
	public interface ILoginRepository
	{

		LoginModel CheckLogin(string login);
        bool CheckPswrd(string pswrd);

        int CheckType(LoginModel login);
    }
}
