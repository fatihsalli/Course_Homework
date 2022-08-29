using System;

namespace CA_FootballTeam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FootballTeam team = new FootballTeam();

            Console.WriteLine("***************************");
            Console.WriteLine("Futbol Oyununa Hoşgeldiniz!");
            Console.WriteLine("***************************");

            while (true)
            {
                Console.WriteLine("Seçenekler: \n1.Oyuncu eklemek için - (add)\n2.Oyuncuları listelemek için - (list)\n3.Oyuncuları güncellemek için - (update)\n4.Oyuncu silmek için - (delete)\n5.Oyuna başlamak için - (play)\n6.Oyundan çıkmak için - (exit)");
                string selected = Console.ReadLine().ToLower();

                if (selected != "exit")
                {
                    switch (selected)
                    {
                        case "add":
                            FootballTeam teamAdd = new FootballTeam();
                            Console.WriteLine(team.AddTeamMember(team.ForAddQuestions(teamAdd)));
                            continue;

                        case "list":
                            team.ListFootballTeam();
                            continue;

                        case "update":
                            Console.WriteLine("Güncellemek istediğiniz futbolcunun Id numarasını giriniz.");
                            int idUpdate = int.Parse(Console.ReadLine());
                            FootballTeam updated = team.GetTeamMemberById(idUpdate); //class instance almıyoruz değeri eşitliyoruz.
                            Console.WriteLine(team.UpdateTeamMember(updated));
                            continue;

                        case "delete":
                            Console.WriteLine("Silmek istediğiniz futbolcunun Id numarasını giriniz.");
                            int idDelete = int.Parse(Console.ReadLine());
                            FootballTeam deleted = team.GetTeamMemberById(idDelete);
                            Console.WriteLine(team.DeleteTeamMember(idDelete));
                            continue;

                        case "play":

                            if (team.ArrayListFootballTeam().Count >= 1)
                            {
                                Console.WriteLine("Oyuna başlamak için aşağıdaki sıralı oyunculardan birinin Id'sini seçin.");
                                team.ListFootballTeam();
                                int selectedPlayId = int.Parse(Console.ReadLine());
                                FootballTeam teamPlay = team.GetTeamMemberById(selectedPlayId);
                                Console.WriteLine("***************************");
                                Console.WriteLine($"{teamPlay.FirstName} {teamPlay.LastName} isimli oyuncuyu seçtiniz.");
                                Console.WriteLine("***************************");
                                team.PlayGame(teamPlay);
                            }
                            else
                            {
                                Console.WriteLine("Oyunu oynayabilmek için en az 1 oyuncu giriniz.");
                            }
                            continue;
                    }
                }
                else
                {
                    break;
                } 
            }

            Console.Read();
        }
    }
}
