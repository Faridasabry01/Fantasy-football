using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    abstract public class Person
    {
        public string name;
        public int age;
        public string nationality;
        private decimal salary;
        public int matches_won;
        public decimal Salary
        {
          get
          {
            return salary;

          }
          set
          {
            if (value > 0)
                salary=value;
          }
        }
       public Person() { }
       public Person(string name,int age,string nat,decimal sal,int matches)
       {
        this.name = name;
        this.age = age;
        nationality = nat;
        salary = sal;
            matches_won = matches;
       }
    public abstract decimal final_salary();
    }
}
