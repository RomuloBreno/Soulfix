using Soulfix.Models;

namespace Soulfix.Helper
{
	public interface ISessionUser
	{

		void CreateSession(UserModel user);
		void EndSession();
		UserModel GetSession();
		
	}
}
