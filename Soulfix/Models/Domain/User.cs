using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soulfix.Models.Domain
{
    public class User : Pessoa
    {

        private Guid IdUser { get; set; }
        private string Job { get; set; }
        public User(Guid idUser, string job, string name, string email, string phone, string cpf)
        {
            IdUser = idUser;
            Job = job;
            Name = name;
            Email = email;
            Phone = phone;
            CPF = cpf;
        }



        public void CreateUser(Event userObject)
        {
            //clientObject.CreateInDataBase();
        }


        public void DeletUser(Event userObject)
        {
            //clientObject.CreateInDataBase();
        }

    }
}
