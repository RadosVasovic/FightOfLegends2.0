using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightOfLegends2._0
{
    abstract class Player
    {
        public int healt;
        //protected int dmg;
        public int cd;
        
        protected Player() 
        { 
           // this.healt = healt;
        }

        public abstract int attack();

        public abstract void takeDmg(int dmg);

        public abstract double getHp();

        public abstract void makeAbility(Form1 form);

        public abstract void resetAbility();
        //protected abstract void GetHealt(int healt);

        public abstract void changeTag(string tag);
    }
}
