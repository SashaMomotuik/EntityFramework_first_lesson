using EntityFramework_first_lesson.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_first_lesson
{
    class Program
    {
        static void Main(string[] args)
        {

            using (EFContext context = new EFContext())
            {

                UserProfile aslan = new UserProfile
                {
                    Name = "Petro",
                    Image = "2.jpg",
                    Telephone = "777"
                };
                context.UserProfiles.Add(aslan);
                context.SaveChanges();
                Console.WriteLine($"User add id = {aslan.Id} ");

            }










        }
    }
}
