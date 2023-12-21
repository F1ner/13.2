using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siglov_Ababiy
{
    class Edition
    {
        string name, surname;
        int year;
        public Edition() { }
        public Edition(string name, string surname, int year)
        {
            this.Name = name;
            this.Surname = surname; this.Year = year;
        }

        public string Name
        {
            get { return (name != "") ? name : "Неизвестно"; }
            set { name = value; }
        }
        public string Surname
        {
            get { return (surname != "") ? surname : "Неизвестно"; }
            set { surname = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = (value < 0 || value > 2023) ? 0 : value; }
        }
        public override string ToString()
        {
            return $"Name-{name}\tSurname-{surname}\tYear-{year}";
        }
        public void God()
        {
            Console.WriteLine("количество лет:");
            int y = int.Parse(Console.ReadLine());
            this.Year = year + y;
            Console.WriteLine(Year);
        }
        public void Interval()
        {
            if (this.Year > 0 & this.Year < 2000)
            {
                Console.WriteLine("Год попадает в интервал");
            }
            else { Console.WriteLine("Год не попадает в интервал "); }
        }
    }
}
