using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr01._03
{
    class Student:Person
    {
        int course { get; set; }
        public Student() { }
        public Student(string name,string surname,DateTime day,string fakul,int course):base(name,surname,day,fakul)
        {
            this.course = course;
        }

        public override void Print()
        {
            Console.WriteLine($"Имя-{name}\nФамилия-{surname}\nДата рождения-{day}\nФакультет-{fakul}\nКурс-{course}");
        }

        public override void AgeNow()
        {
            
        }
    }
}
