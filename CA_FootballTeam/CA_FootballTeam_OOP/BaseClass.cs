using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FootballTeam_OOP
{
    public abstract class BaseClass
    {
        public int Id { get; set; }
        public abstract string Create();
        public abstract void GetList();
        public abstract void AddJerseyNumber();
        public abstract Player GetById(int id);
        public abstract string Update(Player model);
        public abstract void PlayGame(Player teamPlay);
        public abstract Player RandomTeam();



    }
}
