using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_6_Classlibirary
{
   public abstract class MonthlySalaryEmployee : Employee
   {

        public MonthlySalaryEmployee(string _name, int _age,double _monthlysalary) : base(_name, _age)
        {
            this.MonthlySalary = _monthlysalary;

        }


        public double MonthlySalary { get; set; }

        public override double GetSalary()
        {
            return this.MonthlySalary + this.GetBonus();
        }





    }
}
