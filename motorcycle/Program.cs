using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace motorcycle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Motorcycle m1 = new Motorcycle();
            Motorcycle m2 = new Motorcycle("Harley Davidson", true);

            Console.WriteLine(m2.ToString());
            m2.shiftGearsUp();
            Console.WriteLine(m2.ToString());
            m2.Rpm = 500;
            Console.WriteLine(m2.ToString());
            m2.start();
            Console.WriteLine(m2.ToString());



            Console.ReadKey();
        }
    }
}
