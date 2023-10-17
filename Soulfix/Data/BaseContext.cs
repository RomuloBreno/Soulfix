using Microsoft.EntityFrameworkCore;
using Soulfix.Models;

namespace Soulfix.Data
{
    //get Context of framework DbContext
    public class BaseContext : DbContext
    {
        //injection context in constructor and inject(Base) options in Context of framework to use 
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }

        public DbSet<ClientModel> Client { get; set; }
        public DbSet<UserModel> User { get; set; }
        public DbSet<EventModel> Event { get; set; }
        public DbSet<CategoryModel> Category { get; set; }

    }
}
