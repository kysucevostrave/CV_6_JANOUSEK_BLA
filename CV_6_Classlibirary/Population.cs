using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_6_Classlibirary
{
    public class Population
    {

        public int personCount=0;

        Person[] persons = new Person[5];

        public void Add(Person p)
        {
            persons[personCount] = p;   
            personCount++;
        }

        public void PrintUnemployed() 
        {
            for (int i = 0; i < personCount; i++)
            {
                if (persons[i] is Unemployed)
                {
                    persons[i].PrintInfo();
                }

            }
        
        }
        public void PrintEmployeesWithSallary()
        {
            for (int i = 0; i < personCount; i++)
            {
                if (persons[i] is Employee)
                {
                    persons[i].PrintInfo();
                }

            }
        }
        public Person GetPersonWithHighestSallary()
        {
            Person tmp = persons[0];
            for (int i = 1; i < personCount; i++)
            {
                if (persons[i] is Employee && (Employee)persons[i] > (Employee)tmp)
                {
                    tmp = persons[i];
                }

            }

            return tmp;
        }

        public HourlySalaryEmployee[] GetHorlySallaryEmployees()
        {
            HourlySalaryEmployee[] hourlyEmployees = new HourlySalaryEmployee[personCount];
            int index = 0; 
            for (int i = 0; i < personCount; i++)
            {
                if (persons[i] is HourlySalaryEmployee)
                {
                    hourlyEmployees[index] = (HourlySalaryEmployee)persons[i];
                    index++;
                }

            }


            return hourlyEmployees;
        }

    }
}
