using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CA_FootballTeam_OOP
{
    public class Action : BaseClass
    {
        public static int sayac { get; set; } = 1;

        /// <summary>
        /// Takımın otomatik oluşturulup özelliklerin atandığı kısımdır.
        /// </summary>
        /// <returns></returns>
        public override string Create()
        {
            Random randomAdd = new Random();
            while (sayac<12)
            {
                Player player = new Player();
                player.Id = sayac;
                player.Name = $"Oyuncu {player.Id}";
                if (sayac==1)
                {
                    player.Position = "Kaleci";
                    player.ShotPower = randomAdd.Next(0, 50);
                    player.HitRating = randomAdd.Next(0, 50);
                    player.PressPower = randomAdd.Next(0, 50);
                    player.GoalkeepingPower = randomAdd.Next(75, 100);
                    player.DriplingPower = randomAdd.Next(0, 50);
                }
                else if(sayac>1 && sayac<6)
                {
                    player.Position = "Defans";
                    player.ShotPower = randomAdd.Next(0, 50);
                    player.HitRating = randomAdd.Next(0, 50);
                    player.PressPower = randomAdd.Next(75, 100);
                    player.GoalkeepingPower = randomAdd.Next(0, 50);
                    player.DriplingPower = randomAdd.Next(0, 50);
                }
                else if (sayac>=6 && sayac<=9)
                {
                    player.Position = "Orta Saha";
                    player.ShotPower = randomAdd.Next(0, 100);
                    player.HitRating = randomAdd.Next(0, 100);
                    player.PressPower = randomAdd.Next(0, 50);
                    player.GoalkeepingPower = randomAdd.Next(0, 50);
                    player.DriplingPower = randomAdd.Next(75, 100);
                }
                else
                {
                    player.Position = "Forvet";
                    player.ShotPower = randomAdd.Next(75, 100);
                    player.HitRating = randomAdd.Next(75, 100);
                    player.PressPower = randomAdd.Next(0, 100);
                    player.GoalkeepingPower = randomAdd.Next(0, 50);
                    player.DriplingPower = randomAdd.Next(0, 100);
                }
                sayac++;
                Container.footballTeam.Add(player);
            }

            return "Takım Oluşturuldu!";
        }
        /// <summary>
        /// Listeleme için kullanılır. Direkt methodu çağırmak yeterlidir.
        /// </summary>
        public override void GetList()
        {
            foreach (Player p in Container.footballTeam)
            {
                Console.WriteLine(p);
                Console.WriteLine("*********************");
            }
        }

        /// <summary>
        /// Forma numarası eklemek için. Create kısmından ayrı tutuldu birleştirilebilir de. Tekrarsız olacak şekilde 1 ile 99 arasında sayı veriyor.
        /// </summary>
        public override void AddJerseyNumber()
        {
            Random random = new Random();
            int[] dizi = new int[11];
            int a = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                int rastgele = random.Next(1, 100);
                dizi[i] = rastgele;
                for (int j = 0; j < i; j++)
                {
                    if (dizi[i] == dizi[j])
                    {
                        i--;
                        continue;
                    }
                }
            }
            
            foreach (Player p in Container.footballTeam)
            {
                p.JerseyNumber = dizi[a];
                a++;
            }
        }

        /// <summary>
        /// Gelen Id'ye göre listedeki Player ismindeki Class'ı bize teslim eder. Bu class üzerinde yapılan değişiklikler listedeki oyuncuyu değiştirir.
        /// </summary>
        /// <param name="gelenId"></param>
        /// <returns></returns>
        public override Player GetById(int gelenId)
        {
            Player playerId = null;

            foreach (Player p in Container.footballTeam)
            {
                if(p.Id==gelenId)
                {
                    playerId = p;
                    break;
                }
            }
            return playerId;
        }

        /// <summary>
        /// Oyuncu seçerek seçilen oyuncunun özelliklerinin tekrar tanımlanmasına yarar.
        /// </summary>
        /// <param name="pUpdate"></param>
        /// <returns></returns>
        public override string Update(Player pUpdate)
        {
            Random randomAdd = new Random();
            Player player = GetById(pUpdate.Id);

            player.Name = $"Oyuncu {player.Id}";
            if (player.Id == 1)
            {
                player.Position = "Kaleci";
                player.ShotPower = randomAdd.Next(0, 50);
                player.HitRating = randomAdd.Next(0, 50);
                player.PressPower = randomAdd.Next(0, 50);
                player.GoalkeepingPower = randomAdd.Next(75, 100);
                player.DriplingPower = randomAdd.Next(0, 50);
            }
            else if (player.Id > 1 && player.Id < 6)
            {
                player.Position = "Defans";
                player.ShotPower = randomAdd.Next(0, 50);
                player.HitRating = randomAdd.Next(0, 50);
                player.PressPower = randomAdd.Next(75, 100);
                player.GoalkeepingPower = randomAdd.Next(0, 50);
                player.DriplingPower = randomAdd.Next(0, 50);
            }
            else if (player.Id >= 6 && player.Id <= 9)
            {
                player.Position = "Orta Saha";
                player.ShotPower = randomAdd.Next(0, 100);
                player.HitRating = randomAdd.Next(0, 100);
                player.PressPower = randomAdd.Next(0, 50);
                player.GoalkeepingPower = randomAdd.Next(0, 50);
                player.DriplingPower = randomAdd.Next(75, 100);
            }
            else
            {
                player.Position = "Forvet";
                player.ShotPower = randomAdd.Next(75, 100);
                player.HitRating = randomAdd.Next(75, 100);
                player.PressPower = randomAdd.Next(0, 100);
                player.GoalkeepingPower = randomAdd.Next(0, 50);
                player.DriplingPower = randomAdd.Next(0, 100);
            }

            return "Oyuncu güncellendi";
        }


        /// <summary>
        /// Oyun oynama kısmı, dışarıdan Player Classını alır.
        /// </summary>
        /// <param name="teamPlay"></param>
        public override void PlayGame(Player teamPlay)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Seçenekler: \n1.Şut çekmek için - (1)\n2.Press yapmak için - (2)\n3.Topu kurtarmak için - (3)\n4.Çalım atmak için - (4)\n5.Oyuncu değiştirmek için (5)\n6.Ana menü için (6)");
                    int selected = int.Parse(Console.ReadLine());

                    if (selected == 1)
                    {
                        int teamScore = (teamPlay.ShotPower + teamPlay.HitRating) / 2;
                        int otherTeamScore = RandomTeam().GoalkeepingPower;

                        if (teamScore > otherTeamScore)
                        {
                            Console.WriteLine("***************************");
                            Console.WriteLine($"Goooooooool!\nSizin gücünüz:{teamScore}-Rakip gücü:{otherTeamScore}");
                            Console.WriteLine("***************************");
                        }
                        else
                        {
                            Console.WriteLine("***************************");
                            Console.WriteLine($"Kaleci topu kurtardı!\nSizin gücünüz:{teamScore}-Rakip gücü:{otherTeamScore}");
                            Console.WriteLine("***************************");
                        }
                    }
                    else if (selected == 2)
                    {
                        int teamScore = teamPlay.PressPower;
                        int otherTeamScore = RandomTeam().DriplingPower;

                        if (teamScore > otherTeamScore)
                        {
                            Console.WriteLine("***************************");
                            Console.WriteLine($"Topu kazandınız!\nSizin gücünüz:{teamScore}-Rakip gücü:{otherTeamScore}");
                            Console.WriteLine("***************************");

                        }
                        else
                        {
                            Console.WriteLine("***************************");
                            Console.WriteLine($"Topu kazanamadınız!\nSizin gücünüz:{teamScore}-Rakip gücü:{otherTeamScore}");
                            Console.WriteLine("***************************");
                        }
                    }
                    else if (selected == 3)
                    {
                        int teamScore = teamPlay.GoalkeepingPower;
                        int otherTeamScore = (RandomTeam().ShotPower + RandomTeam().HitRating) / 2;

                        if (teamScore > otherTeamScore)
                        {
                            Console.WriteLine("***************************");
                            Console.WriteLine($"Şutu çıkardınız!\nSizin gücünüz:{teamScore}-Rakip gücü:{otherTeamScore}");
                            Console.WriteLine("***************************");
                        }
                        else
                        {
                            Console.WriteLine("***************************");
                            Console.WriteLine($"Malesef gol yediniz!\nSizin gücünüz:{teamScore}-Rakip gücü:{otherTeamScore}");
                            Console.WriteLine("***************************");
                        }
                    }
                    else if (selected == 4)
                    {
                        int teamScore = teamPlay.DriplingPower;
                        int otherTeamScore = RandomTeam().PressPower;

                        if (teamScore > otherTeamScore)
                        {
                            Console.WriteLine("***************************");
                            Console.WriteLine($"Çalım attınız!\nSizin gücünüz:{teamScore}-Rakip gücü:{otherTeamScore}");
                            Console.WriteLine("***************************");
                        }
                        else
                        {
                            Console.WriteLine("***************************");
                            Console.WriteLine($"Çalım atamadınız topu kaptırdınız!\nSizin gücünüz:{teamScore}-Rakip gücü:{otherTeamScore}");
                            Console.WriteLine("***************************");
                        }
                    }
                    else if (selected == 5)
                    {
                        Console.WriteLine("Oyuncu Listesi");
                        GetList();
                        Console.WriteLine("Yeni oyuncu Id seçiniz.");
                        int selectedPlayId = int.Parse(Console.ReadLine());

                        teamPlay = GetById(selectedPlayId);

                        Console.WriteLine($"{teamPlay.Name} isimli oyuncuyu seçtiniz.");

                    }
                    else if (selected == 6)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı bir değer girdiniz!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// Random team karşı rakip oluştumak için kullanılmaktadır. Değer almaz Player Classı dışarıya verir.
        /// </summary>
        /// <returns></returns>
        public override Player RandomTeam()
        {
            Player teamRandom = new Player();
            Random randomTeam = new Random();

            teamRandom.GoalkeepingPower = randomTeam.Next(60, 100);
            teamRandom.DriplingPower = randomTeam.Next(60, 100);
            teamRandom.ShotPower = randomTeam.Next(60, 100);
            teamRandom.HitRating = randomTeam.Next(60, 100);
            teamRandom.PressPower = randomTeam.Next(60, 100);
            return teamRandom;
        }



    }
}
