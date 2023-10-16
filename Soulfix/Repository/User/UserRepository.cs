using Soulfix.Data;
using Soulfix.Models;

namespace Soulfix.Repository.User
{
    public class UserRepository : IUserRepository
    {


        //Injeção do contexto do banco via construtor dentro do repositorio para fazer CRUD

        private readonly BaseContext _baseContext;
        public UserRepository(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }



        public UserModel Create(UserModel User)
        {
            _baseContext.User.Add(User);
            _baseContext.SaveChanges();
            return User;
        }


        public List<UserModel> GetList()
        {
            return _baseContext.User.ToList();
        }
    }
}
