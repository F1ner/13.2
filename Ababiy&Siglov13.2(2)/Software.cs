using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiy_Siglov13._2_2_
{
    internal class Software
    {/// <summary>
    /// поля описывающие имя, имя производителя, стоимость
    /// </summary>
        string name,owner;
        bool prise;
        /// <summary>
        /// конструктор с пустым параметром
        /// </summary>
        public Software() { }
        /// <summary>
        /// конструктор с 3 параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="owner"></param>
        /// <param name="prise"></param>
        public Software(string name, string owner, bool prise)
        {
            this.Name = name;
            this.Owner = owner;
            this.Prise = prise;
        }
        /// <summary>
        /// свойства описывающие поле имя
        /// </summary>
        public string Name
        {
            get { return (name != "") ? name : "Неизвестно"; }
            set { name = value; }
        }
        /// <summary>
        /// свойства описывающие поле имя производителя
        /// </summary>
        public string Owner
        {
            get { return (owner != "") ? owner : "Неизвестно"; }
            set { owner = value; }
        }
        /// <summary>
        /// свойства описывающие поле стоимость
        /// </summary>
        public bool Prise
        {
            //get;
            //set;
            get
            {
                return prise;
            }
            set
            {
                prise = value;
            }

        }
        /// <summary>
        /// метод вывода
        /// </summary>
        /// <returns></returns>

        public override string ToString() 
        {
            return $"Name-{name}\tOwner-{owner}\tPrise-{prise}";
        }
    }
}
