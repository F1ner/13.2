using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siglov_Ababiy
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a = Console.ReadLine();
            //string c = Console.ReadLine();
            //int b = int.Parse(Console.ReadLine());
            //Edition edition = new Edition(a, c, b);
            //Edition edition1 = new Edition();
            //Edition edition2 = new Edition("pavel", "chechov", 1912);


            //Console.WriteLine($"{edition.ToString()}");
            //edition.God();
            //edition.Interval();
            //Software software = new Software();
            //software.Name = "Kaspersy";
            //software.Owner = "Russia";
            //software.Prise = true;
            //Console.WriteLine($"{software.ToString()}\n");
            //Software software1 = new Software();
            //Software software2 = new Software();
            string d = Console.ReadLine();
            int f = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            Banknote banknote = new Banknote();
            banknote.Init();
            Banknote banknote1 = new Banknote();
            banknote1.Init();
            Banknote banknote2 = new Banknote(d,f,z);
            Console.WriteLine($"{banknote.ToString()}\n{banknote1.ToString()}\n{banknote2.ToString()}");
            banknote.Kvo();
            Console.WriteLine($"{banknote.ToString()}");
            banknote.Prov();
            Console.ReadKey();
        }
    }
}
