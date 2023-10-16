using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soulfix.Models.Domain
{
    public class Client : Pessoa
    {
        public Guid IdClient { get; set; }
        private string CNPJ { get; set; }
        private string Beens { get; set; }


        public Client(Guid idClient, string beens, string name, string email, string phone, string cnpj)
        {
            IdClient = idClient;
            Beens = beens;
            Name = name;
            Email = email;
            Phone = phone;
            CNPJ = cnpj;
        }



        public void CreateClient(Event clientObject)
        {
            //clientObject.CreateInDataBase();
        }


        public void DeletClient(Event clientObject)
        {
            //clientObject.CreateInDataBase();
        }
    }




}
