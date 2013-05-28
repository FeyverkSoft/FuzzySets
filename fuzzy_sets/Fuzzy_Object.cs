using Fuzzy_sets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fuzzy_sets_GUI
{
    /// <summary>
    /// Объект содержащий множество и его название
    /// </summary>
    /// <typeparam name="T">Тип элемента множества</typeparam>
    public class Fuzzy_Object<T> where T : IComparable<T>
    {
        //Название множества
        String name = "";
        //само множество
        Fuzzy_sets<T> sets = new Fuzzy_sets<T>();
        /// <summary>
        /// Имя множества
        /// </summary>
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// Нечёткое множество
        /// </summary>
        public Fuzzy_sets<T> Sets
        {
            get { return sets; }
            set { sets = value; }
        }
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="Fuzzy">Нечеткое множество</param>
        /// <param name="Name">Название множества</param>
        public Fuzzy_Object(Fuzzy_sets<T> Fuzzy, String Name = "")
        {
            this.Name = Name;
            this.Sets = Fuzzy;
        }
        /// <summary>
        /// Возвращает строковое представление класса
        /// </summary>
        /// <returns>Возвращает строковое представление класса</returns>
        public override string ToString()
        {
            return Name + "=" + Sets.ToString() + ";";
        }
    }
}
