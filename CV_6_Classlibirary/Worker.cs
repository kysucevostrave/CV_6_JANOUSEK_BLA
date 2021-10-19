using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_6_Classlibirary
{
    public class Worker : HourlySalaryEmployee
    {
        public Worker(string _name, int _age ) : base(_name, _age, 130)
        {
           
        }

        public override double GetBonus()
        {
            if (this.HourlySalary > 160)
            {
                return 5000;
            }
            else
            {
                return 0;
            }
        }




    }
}
