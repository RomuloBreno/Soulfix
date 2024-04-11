using Newtonsoft.Json;
using Soulfix.Models;

namespace Soulfix.Helper
{
	public class SessionUser : ISessionUser
	{

		private readonly IHttpContextAccessor _httpContext;


        public SessionUser(IHttpContextAccessor httpContext)
        {
			_httpContext = httpContext;

		}

        public void CreateSession(UserModel user)
		{
			string value = JsonConvert.SerializeObject(user);
			_httpContext.HttpContext.Session.SetString("token",value);
		}

		public void EndSession()
		{
			_httpContext.HttpContext.Session.Remove("token");
		}

		public UserModel GetSession()
		{
			string session = _httpContext.HttpContext.Session.GetString("token");

			if (string.IsNullOrWhiteSpace(session)) return null;

			return JsonConvert.DeserializeObject<UserModel>(session);
		}
	}
}
