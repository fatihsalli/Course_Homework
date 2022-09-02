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






    }
}
