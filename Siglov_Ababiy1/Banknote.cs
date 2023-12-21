using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siglov_Ababiy
{
    class Banknote
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
        public string Name
        {
            get { return (name != "") ? name : "Неизвестно"; }
            set { name = value; }
        }
        public int Nominal
        {
            get
            {
                return nominal ;
            }
            set
            {

                if (value > 0)
                {
                    nominal=value;
                }
                else
                {
                    nominal = 0;
                    Console.WriteLine("Такого номинала не бывает");
                }
            }
        }
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (value > 0)
                {
                    amount=value;
                }
                else
                {
                    amount = 0;
                    Console.WriteLine("Количество равно нулю");
                }
            }
        }
        public override string ToString()
        {
            return $"Name-{name}\tNominal-{nominal}\tAmount-{amount}";
        }
        public void Init()
        {
            Console.WriteLine("Введите название");
            Name = Console.ReadLine();
            Console.WriteLine("Введите номинал");
            Nominal = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество");
            Amount= int.Parse(Console.ReadLine());
        }
        public void Kvo(int y)
        {
            this.Amount = amount + y;
            Console.WriteLine(Amount);
        }
        public void Prov(int x)
        {
            
            string z = (x > nominal * amount) ? "Суммы не достаточно" : "Суммы достаточно";
            //if (x > nominal * amount)
            //{
            //    Console.WriteLine("Суммы не достаточно");
            //}
            //else
            //{
            //    Console.WriteLine("Суммы достаточно");
            //}
        }
    }
}
