using Soulfix.Controllers;

using Microsoft.EntityFrameworkCore;
using Soulfix.Data;
using Soulfix.Models;

namespace Soulfix.Repository.Login
{
	public class LoginRepository : ILoginRepository
	{
		private readonly BaseContext _baseContext;

		public LoginRepository(BaseContext baseContext)
		{
			_baseContext = baseContext;
		}


		public LoginModel CheckLogin(string login)
		{
			return _baseContext.Login.FirstOrDefault(x => x.Login == login);
		}

		public bool CheckPswrd(string pswrd)
		{
			LoginModel checkPswrd = _baseContext.Login.FirstOrDefault(x => x.Pswrd == pswrd);
			if (checkPswrd != null)
			{
				return true;
			}
			return false;
		}

        public int CheckType(LoginModel login)
        {
            LoginModel checktype = _baseContext.Login.FirstOrDefault(x => x.Login == login.Login && x.Pswrd == login.Pswrd );
            if (checktype != null)
            {
                return checktype.Type;
            }
			return 0;
        }



    }
}
