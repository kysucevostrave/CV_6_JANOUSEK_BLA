using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_6_Classlibirary
{
    public class Secretary : MonthlySalaryEmployee
    {
        public Secretary(string _name, int _age) : base(_name, _age, 2000)
        { 

        }
        public override void PrintInfo()
        {
            Console.WriteLine(Name + " " + Age + "  Pozice: Sekretarka");
        }
    }
}
/*
 *  class Manager : MonthlySalaryEmployee
    {
        public Manager(string _name, int _age) : base(_name, _age, 80000)
        {
            
        }


        
        public override double GetSalary()
        {
            return this.MonthlySalary + (this.Age * 500) + this.GetBonus();
        }
        public override void PrintInfo()
        {
            Console.WriteLine(Name + " " + Age + "  Pozice: manager"  ) ;
        }
    }*/