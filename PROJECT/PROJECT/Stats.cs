using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    class Stats:Interface1
    {
        public string team;
        public int cups;
        public int awards;
        public int cards;

        public Stats() { }
        public Stats(string t,int cu,int a,int ca)
        {
            team = t;
            cups = cu;
            awards = a;
            cards = ca;
        }
        public string Suspention()
        {
            if (cards == 1)
                return "Warning!";
            else if (cards > 1)
                return "Suspended";
            else
                return "No Warning";
        }  

    }
}
