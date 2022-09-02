using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FootballTeam_OOP
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int JerseyNumber { get; set; }
        //Property - Yetenekler mevkisine göre random değer atamaktadır.
        public int ShotPower { get; set; } //Shut gücü
        public int HitRating { get; set; } //İsabetli vuruş
        public int PressPower { get; set; } //Defans gücü
        public int GoalkeepingPower { get; set; } //Top kurtarma yeteneği
        public int DriplingPower { get; set; } //Top sürme yeteneği

        /// <summary>
        /// To String methodu kullanıldı. Class herhangi bir yerde yazdırıldığında otomatik yazacak.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Id:{Id} Oyuncu:{Name} Pozisyon:{Position} Forma Numarası:{JerseyNumber}\nÖzellikler - Şut:{ShotPower} İsabet:{HitRating} Pres:{PressPower} Kalecilik:{GoalkeepingPower} Dripling: {DriplingPower}";
        }




    }
}
