using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1_OOP_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat(12);
            Cat cat2 = new Cat(4);
            Cat cat3 = new Cat(8);
            int x = cat1.Age;
            int y = cat2.Age;
            int z = cat3.Age;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Cat.AgeCom(x, y, z);


        }
    }
}
