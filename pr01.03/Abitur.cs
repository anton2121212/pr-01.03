using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr01._03
{
    class Abitur:Person
    {
        public Abitur(string name, string surname, DateTime day, string fakul) : base(name, surname, day, fakul)
        {

        }
        public override void Print()
        {
           
           Console.WriteLine($"Имя-{name}\nФамилия-{surname}\nДата рождения-{day}\nФакультет-{fakul}");
        }
        public override void AgeNow()
        {
            Console.WriteLine($"");
        }

    }
    }
}
