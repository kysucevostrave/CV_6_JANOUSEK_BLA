using System;

namespace CV_6_Classlibirary
{
    public class Person
    {
        public readonly string Name;

        public  int Age { get; set; }


        public virtual void PrintInfo()
        {


            Console.WriteLine(Name + " " + Age);

        }

        public Person(string _name,int _age)
        {
            this.Age = _age;
            this.Name = _name;


        }





    }


}
