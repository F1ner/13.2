using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy_Siglov13._2_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Software software = new Software();
            software.Name = "Kaspersy";
            software.Owner = "Russia";
            software.Prise = true;
            Console.WriteLine($"{software.ToString()}\n");
            //Software software1 = new Software();
            //Software software2 = new Software();



            Console.ReadKey();
        }
    }
}
