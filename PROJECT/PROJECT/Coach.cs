using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    class Coach:Person
    {
        public int Yrs_exp;
        public Coach() { }
        public Coach(string name,int age,string nat,decimal sal,int matches,int years):base(name, age, nat, sal,matches)
        {
            Yrs_exp = years;
        }
        public override decimal final_salary()
        {
            return Salary = Salary + (matches_won * Salary * 0.1M);
        }
        public override string ToString()
        {
            return String.Format("Coach name:{0} \nAge:{1} \nNationality:{2} \nSalary{3:c} \nMatches Won:{4} \nYears of experience:{5} \nSalary with bonus:{6:c} \n", name,age,nationality,Salary,matches_won,Yrs_exp,final_salary());
        }

    }
}
