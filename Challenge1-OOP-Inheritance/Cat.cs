using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1_OOP_Inheritance
{
    class Cat
    {
        private string _species = "mamma1";
        private int _age;

        public string Species { get => _species; set => _species = value; }
        public int Age {

            get { return _age; }
            set {
                    if (value>0)
                    {
                        _age = value;
                    }
            }
              
        }

       public Cat(int _age)
        {
            Age = _age;
        }

        public static void AgeCom(int x, int y, int z)
        {
            if (x> y && x> z)
            {
                Console.WriteLine("Cat1 is oldest cat");
            }
            else if (y > x && y > z)
            {
                Console.WriteLine("Cat2 is oldest cat");
            }
            else
            {
                Console.WriteLine("Cat3 is oldest cat");
            }
        }




    }
}
