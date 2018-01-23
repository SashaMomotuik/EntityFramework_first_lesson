using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_first_lesson.Entities
{
   public class EFContext : DbContext
    {

        public EFContext() :base("ConnectionShopDB")
        {
            
        }

        public DbSet<UserProfile> UserProfiles { get; set; }  //так називатиметься таблиця UserProfiles


    }
}
