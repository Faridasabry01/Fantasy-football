using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    abstract class Player : Person
    {
        public int number;
        public string position;
        public Stats stat;
        public Player() { }
        public Player(string name, int age, string nat, decimal sal, int matches, int num, string pos,Stats stat) : base(name, age, nat, sal, matches)
        {
            number = num;
            position = pos;
            this.stat = stat;
        }
        //public abstract void final_salary();
    }
}
