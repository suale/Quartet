using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            StaticDeneme.metod();
            StaticDeneme.metod();
            StaticDeneme.metod();
            StaticDeneme.metod();
            StaticDeneme.metod();
            StaticDeneme staticDeneme = new StaticDeneme();
            Console.WriteLine(staticDeneme.nonStatic());
            Console.ReadLine();



        }
    }
}
