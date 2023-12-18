using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy_Siglov13._2_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string c = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            Edition edition= new Edition(a,c,b);
            Edition edition1 = new Edition();
            Edition edition2 = new Edition("pavel","chechov",1912);

            
            Console.WriteLine($"{edition.ToString()}");
            edition.God();
            edition.Interval();
            Console.ReadKey();
        }
    }
}
