using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreFirstFromDatabase
{`
    class Program
    {
        static void Main(string[] args)
        {
            using (Model1 db = new Model1())
            {
                User user1 = new User { Name = "Alex", Age = 30 };
                User user2 = new User() { Name = "Anton", Age = 45 };

                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
                Console.WriteLine("База обновлена");
                Console.ReadKey();

                Console.WriteLine("Чтение из базы данных");

                List<User> list = db.Users.ToList();

                foreach (var item in list)
                {
                    Console.WriteLine("{0}.{1} - {2}", item.Id, item.Name, item.Age);
                }

                //foreach (var item in db.users)
                //{
                //    console.writeline("{0}.{1} - {2}", item.id, item.name, item.age);
                //}
                Console.ReadKey();
            }
           
        }
    }
}
