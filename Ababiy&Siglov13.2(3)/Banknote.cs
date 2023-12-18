using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy_Siglov13._2_3_
{
    internal class Banknote
    {
        string name;
        int nominal, amount;

        public Banknote() { }

        public Banknote(string name, int nominal, int amount) 
        {
            this.Name = name;
            this.Nominal = nominal;
            this.Amount = amount;
        }
        public string Name {
            get { return (name != "") ? name : "Неизвестно"; }
            set { name = value; }
        }
        public int Nominal {
            get
            {
                nominal = value;
            }
            set
            {
                if (nominal > 0) Console.WriteLine(nominal);
                else Console.WriteLine("Такого номинала не бывает");
            }
        }
        public int Amount {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }
    }
}
