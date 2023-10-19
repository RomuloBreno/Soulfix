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


        public UserModel Update(UserModel user)
        {

            UserModel _user = GetForUpdate(user.Id);

            _user.Name = user.Name;
            _user.Email = user.Email;   
            _user.Phone = user.Phone;
            _user.CPF = user.CPF;
            _user.Job = user.Job;

            _baseContext.User.Update(_user);
            _baseContext.SaveChanges();
            return _user;
        }

        public UserModel GetForUpdate(int id)
        {
            return _baseContext.User.FirstOrDefault(x => x.Id == id);
           
        }

        public UserModel Delete(UserModel user)
        {
            _baseContext.User.Remove(user);
            _baseContext.SaveChanges();
            return user;
        }

      
    }
}
