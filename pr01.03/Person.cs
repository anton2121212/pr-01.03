using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr01._03
{
    abstract class Person
    {
        protected string name { get; set; }
        protected string surname { get; set; }
        protected DateTime day { get; set; }
        protected string fakul { get; set; }
      

        public Person() { }
        public Person(string name, string surname, DateTime day, string fakul) 
        {
            this.name = name;
            this.surname = surname;
            this.day = day;
            this.fakul = fakul;
        }
        abstract public void Print();

        abstract public void AgeNow();
      
    }
}
