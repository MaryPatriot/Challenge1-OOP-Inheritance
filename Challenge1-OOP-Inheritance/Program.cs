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
            Cat cat1 = new Cat(16);
            Cat cat2 = new Cat(34);
            Cat cat3 = new Cat(9);
            //int x = cat1.Age;
            //int y = cat2.Age;
            //int z = cat3.Age;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            Console.WriteLine(cat1.Age);
            Console.WriteLine(cat2.Age);
            Console.WriteLine(cat3.Age);
            Cat.AgeCom(cat1.Age, cat2.Age, cat3.Age);


        }
    }
}
