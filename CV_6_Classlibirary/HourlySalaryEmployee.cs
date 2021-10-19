using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_6_Classlibirary
{
    public abstract class HourlySalaryEmployee : Employee
    {

        public HourlySalaryEmployee(string _name, int _age, double _hourlysalary) : base(_name, _age)
        {
            this.HourlySalary = _hourlysalary;

        }


        public double HourlySalary { get; set; }
        public int HoursWorked { get; set; }

        public override double GetSalary()
        {
            return (this.HourlySalary * HoursWorked) + this.GetBonus();
        }

    }
}
