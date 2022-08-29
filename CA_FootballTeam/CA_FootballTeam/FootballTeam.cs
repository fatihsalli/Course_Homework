using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CA_FootballTeam
{
    public class FootballTeam
    {
        //Arraylist public alanda
        ArrayList footballteam = new ArrayList(); //Sadece class içerisinden direkt müdahale edilebilmesi için bu alanda oluşturduk.
        static int sayac = 0;


        //Property - Kullanıcıdan gelen değerler (Id hariç)
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string WhichFoot { get; set; }
        public string Position { get; set; }
        public int JerseyNumber { get; set; }
        //Property - Yetenekler mevkisine göre random değer atamaktadır.
        public int ShotPower { get; set; } //Shut gücü
        public int HitRating { get; set; } //İsabetli vuruş
        public int PressPower { get; set; } //Defans gücü
        public int GoalkeepingPower { get; set; } //Top kurtarma yeteneği
        public int DriplingPower { get; set; } //Top sürme yeteneği


        //ArrayListFootballTeam // Arrayliste direkt ulaşılamaması için metot içine alındı. İşlem sonucu bize Arraylisti veriyor.
        public ArrayList ArrayListFootballTeam()
        {
            return footballteam;
        }


        //ListFootballTeam // Listeleme işleri için.
        public void ListFootballTeam()
        {
            Console.WriteLine("Oyuncu Listesi");
            foreach (FootballTeam item in footballteam)
            {
                Console.WriteLine("***************************");
                Console.WriteLine($"Id: {item.Id} - Ad-Soyad: {item.FirstName} {item.LastName} - Kullandığı ayak: {item.WhichFoot} - Pozisyon: {item.Position} - Forma Numarası: {item.JerseyNumber}\nÖzellikler - Şut Gücü: {item.ShotPower} - İsabet: {item.HitRating} - Press gücü: {item.PressPower} - Top Kurtarma Gücü: {item.GoalkeepingPower} - Top Sürme: {item.DriplingPower}");
            }
        }

        //AddTeamMember // Ekleme için hazırlandı. Class şeklinde Program.cs deki team'i ArrayList olan footballteam e yazdırıyoruz. Yani değerler Program.cs içindeki verilerden gelecek. Sonrasında string atıyor bize. Şu kişi eklenmiştir şeklinde.
        public string AddTeamMember(FootballTeam team)
        {
            team.Id = sayac + 1;
            sayac++; //sayaç yapılmadığı taktirde delete işleminden sonra tekrarlı ıd veriyor.
            footballteam.Add(team);
            return $"{team.FirstName} isimli futbolcu listeye eklenmiştir.";
        }


        //GetTeamMemberById
        public FootballTeam GetTeamMemberById(int id)
        {
            FootballTeam team = new FootballTeam();
            foreach (FootballTeam item in footballteam)
            {
                if(item.Id == id)
                {
                    team = item;
                    break;
                }
            }
            return team;
        }


        //UpdateTeamMember // Takımdaki oyuncu bilgi güncelleme
        public string UpdateTeamMember(FootballTeam updated)
        {
            updated=ForAddQuestions(updated);

            return $"Futbolcu bilgileri güncellendi.";
        }


        //DeleteTeamMember //Takımdaki oyuncu silmek için
        public string DeleteTeamMember(int id)
        {
            FootballTeam deleted=GetTeamMemberById(id);
            footballteam.Remove(deleted);

            return "Futbolcu silindi.";
        }


        //ForAddQuestions //Soruların olduğu kısım.
        public FootballTeam ForAddQuestions(FootballTeam teamAdd)
        {
            Random randomAdd = new Random();

            Console.WriteLine("Adı: ");
            teamAdd.FirstName = Console.ReadLine();
            Console.WriteLine("Soyadı: ");
            teamAdd.LastName = Console.ReadLine();
            Console.WriteLine("Kullandığı ayak: ");
            teamAdd.WhichFoot = Console.ReadLine();
            Console.WriteLine("Forma numarası: ");
            teamAdd.JerseyNumber = int.Parse(Console.ReadLine()); //tekrarlı olması durumunu ayrıca düşünmemiz gerekiyor.
            Console.WriteLine("Pozisyon: goalkeep // defense // offence ");
            teamAdd.Position = Console.ReadLine().ToLower();

            if(teamAdd.Position=="goalkeep")
            {
                teamAdd.ShotPower = randomAdd.Next(0, 50);
                teamAdd.HitRating = randomAdd.Next(0, 50);
                teamAdd.PressPower = randomAdd.Next(0, 50);
                teamAdd.GoalkeepingPower = randomAdd.Next(75, 100); //Kaleci olduğu için bu özellik yüksek olacak.
                teamAdd.DriplingPower = randomAdd.Next(0, 50);
            }
            else if(teamAdd.Position == "defense")
            {
                teamAdd.ShotPower = randomAdd.Next(50, 70);
                teamAdd.HitRating = randomAdd.Next(50, 70);
                teamAdd.PressPower = randomAdd.Next(75, 100); //Defans olduğu için bu özellik yüksek olacak.
                teamAdd.GoalkeepingPower = randomAdd.Next(0, 50);
                teamAdd.DriplingPower = randomAdd.Next(50, 75);
            }
            else if (teamAdd.Position == "offence")
            {
                teamAdd.ShotPower = randomAdd.Next(75, 100);
                teamAdd.HitRating = (randomAdd.Next(75, 100));
                if(teamAdd.ShotPower>70)
                {
                    teamAdd.HitRating=teamAdd.HitRating-(teamAdd.ShotPower/20); // Şut gücü 70'den yüksek ise isabet oranı düşüyor.
                }
                teamAdd.PressPower = randomAdd.Next(50, 75);
                teamAdd.GoalkeepingPower = randomAdd.Next(0, 50);
                teamAdd.DriplingPower = randomAdd.Next(75, 100);
            }
            return teamAdd;
        }


        //Random Rakip // Oyunu oynamak için
        public FootballTeam RandomTeam()
        {
            FootballTeam teamRandom = new FootballTeam();
            Random randomTeam = new Random();

            teamRandom.GoalkeepingPower = randomTeam.Next(60, 100);
            teamRandom.DriplingPower = randomTeam.Next(60, 100);
            teamRandom.ShotPower = randomTeam.Next(60, 100);
            teamRandom.HitRating = randomTeam.Next(60, 100);
            teamRandom.PressPower = randomTeam.Next(60, 100);
            return teamRandom;
        }


        //PlayGame // Oyunun detayları için
        public void PlayGame(FootballTeam teamPlay)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Seçenekler: \n1.Şut çekmek için - (shot)\n2.Press yapmak için - (press)\n3.Topu kurtarmak için - (goalkeep)\n4.Çalım atmak için - (dribble)\n5.Oyuncu değiştirmek için (change)\n6.Ana menü için (quit)");
                    string selected = Console.ReadLine().ToLower();

                    if (selected == "shot")
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
                    else if (selected == "press")
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
                    else if (selected == "goalkeep")
                    {
                        int teamScore = teamPlay.GoalkeepingPower;
                        int otherTeamScore = (RandomTeam().RandomTeam().ShotPower + RandomTeam().RandomTeam().HitRating) / 2;

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
                    else if (selected == "dribble")
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
                    else if(selected == "change")
                    {
                        Console.WriteLine("Oyuncu Listesi");
                        foreach (FootballTeam item in footballteam)
                        {
                            Console.WriteLine("***************************");
                            Console.WriteLine($"Id: {item.Id} - Ad-Soyad: {item.FirstName} {item.LastName} - Kullandığı ayak: {item.WhichFoot} - Pozisyon: {item.Position} - Forma Numarası: {item.JerseyNumber}\nÖzellikler - Şut Gücü: {item.ShotPower} - İsabet: {item.HitRating} - Press gücü: {item.PressPower} - Top Kurtarma Gücü: {item.GoalkeepingPower} - Top Sürme: {item.DriplingPower}");
                        }
                        Console.WriteLine("Yeni oyuncu Id seçiniz.");
                        int selectedPlayId = int.Parse(Console.ReadLine());

                        teamPlay = GetTeamMemberById(selectedPlayId);

                        Console.WriteLine($"{teamPlay.FirstName} {teamPlay.LastName} isimli oyuncuyu seçtiniz.");

                    }
                    else if (selected == "quit")
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


    }
}
