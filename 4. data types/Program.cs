using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration of a string, an integer, a boolean and a decimal
            string name = "jeff";
            int age = 22;
            bool isTall = true;
            double weight = 88.2;
            char initial = 'j';

            Console.WriteLine("his name is " + name + " he is " + age + " it is " + isTall + " that he is tall");
            Console.WriteLine("he weights " + weight + " his initial is " + initial);
             name = "phato";
             age = 21;
            isTall = false;
             weight = 81.2;
            initial = 'j';

            Console.WriteLine("his name is " + name + " he is " + age + " it is " + isTall + " that he is tall");
            Console.WriteLine("he weights " + weight + " his initial is " + initial);

            //freeze blackscreen/cmd/console
            Console.ReadLine();
        }
    }
}
