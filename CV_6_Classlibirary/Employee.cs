using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_6_Classlibirary
{
    public abstract class Employee : Person
    {

        public Employee(string _name, int _age):base( _name, _age) { 
        
        }

        public virtual  double GetBonus() {
            return 0.0f;
        }

        public abstract double GetSalary();
       
        public static bool operator!=(Employee a, Employee b)
        {
            return (a.GetSalary() != b.GetSalary()) ? true : false;
        }
        public static bool operator ==(Employee a, Employee b)
        {
            return (a.GetSalary() == b.GetSalary()) ? true : false;
        }
        public static bool operator <(Employee a, Employee b)
        {
            return (a.GetSalary() < b.GetSalary()) ? true : false;
        }
        public static bool operator >(Employee a, Employee b)
        {
            return (a.GetSalary() > b.GetSalary()) ? true : false;
        }
    
    
    
    
    
    
    
    }




}
