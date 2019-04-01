using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Context db = new Context())
            {
                Team team_1 = new Team { Id = 1, Name = "Арсенал", Country = "Англия" };
                Team team_2 = new Team { Id = 2, Name = "Спартак", Country = "Россия" };
                Team team_3 = new Team { Id = 3, Name = "Динамо", Country = "Россия" };

                db.Teams.AddRange(new List<Team>
                        {
                            team_1,
                            team_2,
                            team_3
                        });
                db.SaveChanges();

                Player player_1 = new Player { Id = 1, Name = "Александр", Age = 19 };
                Player player_2 = new Player { Id = 2, Name = "Дмитрий", Age = 20 };
                Player player_3 = new Player { Id = 3, Name = "Сергей", Age = 25 };
                Player player_4 = new Player { Id = 4, Name = "Петр", Age = 26 };
                Player player_5 = new Player { Id = 5, Name = "Данил", Age = 30 };

                db.Players.AddRange(new List<Player>
                        {
                            player_1,
                            player_2,
                            player_3,
                            player_4,
                            player_5
                        });
                db.SaveChanges();

                var Команда = db.Teams.ToList();

                var query = Команда.Where(tm => tm.Country == "Россия").
                            Select(tm => new { tm.Id, tm.Name});

                

                Console.WriteLine("Российские команды:");
                int Id = 0;
                foreach (var item in query)
                {
                    Console.WriteLine("{0}. {1}", Id,item.Name);
                    Id++;
                }
                Console.ReadKey();

                var Игроки = db.Players.ToList();

                var query_1 = Игроки.Where(pl => pl.Age >= 25).
                            Select(pl => new { pl.Id, pl.Name });

                Console.WriteLine("Игроки старше или равны 25 годам:");
                Id = 0;
                foreach (var item in query_1)
                {

                    Console.WriteLine("{0}. {1}", Id,item.Name);
                    Id++;
                }
                Console.ReadKey();
            }
        }
    }
}
