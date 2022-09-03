using System;

namespace CA_FootballTeam_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action action=new Action();

            Container.Karsilama();

            while (true)
            {
                try
                {
                    switch (Container.Start())
                    {
                        case 1:
                            Console.WriteLine(action.Create());
                            action.AddJerseyNumber();
                            break;
                        case 2:
                            action.GetList();
                            break;
                        case 3:
                            Console.WriteLine("Değiştirmek istediğiniz oyuncunun Id'sini girin.");
                            int gelenId = int.Parse(Console.ReadLine());
                            Console.WriteLine(action.Update(action.GetById(gelenId)));
                            break;
                        case 4:
                            Container.footballTeam.Clear();
                            Action.sayac = 1;
                            Console.WriteLine(action.Create());
                            action.AddJerseyNumber();
                            break;
                        case 5:
                            Console.WriteLine("Oynamak istediğiniz oyuncunun Id'sini girin.");
                            int playId = int.Parse(Console.ReadLine());
                            action.PlayGame(action.GetById(playId));
                            break;
                        case 6:
                            return;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }




            







        }
    }
}
