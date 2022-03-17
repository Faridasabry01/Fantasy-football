using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    class Field: Player
    {
        public int goals;
        public Field() { }
        public Field(string name, int age, string nat, decimal sal, int matches, int num, string pos,int g,Stats stat) : base(name, age, nat, sal, matches,num,pos,stat)
        {
            goals = g;
        }
        public override decimal final_salary()
        {
            return Salary = Salary + (goals * 0.1M) + (matches_won * 0.05M * Salary);
           
        }
        public override string ToString()
        {
            return String.Format("Name:{0}, \nAge:{1}, \nNationality:{2}, \nSalary:{3:c}, \nMatches Won:{4}, \nNumber:{5}, \nPosition:{6}, \nGoals:{7}, \nSalary with bonus:{8:c}, \nCards:{9}, \nTeam:{10}, \nAwards:{11}, \nCups:{12}, \nBehavior:{13}\n\n", name,age, nationality,Salary,matches_won,number,position,goals,final_salary(), stat.cards, stat.team, stat.awards, stat.cups, stat.Suspention());
        }
    }
}
