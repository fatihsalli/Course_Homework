using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FootballTeam_OOP
{
    public class Container
    {
        public static List<Player> footballTeam = new List<Player>();
        
        public static void Karsilama()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("FUTBOL OYUNUNA HOŞGELDİNİZ!");
            Console.WriteLine("***************************");
            
        }

        public static int Start()
        {
            Console.WriteLine("ANA MENÜ: \n1.Takım kurmak için - (1)\n2.Oyuncuları listelemek için - (2)\n3.Oyuncu seçip güncellemek için - (3)\n4.Yeni takım oluşturmak için - (4)\n5.Oyuna başlamak için - (5)\n6.Oyundan çıkmak için - (6)");
            int selected = int.Parse(Console.ReadLine());
            return selected;
        }




    }
}
