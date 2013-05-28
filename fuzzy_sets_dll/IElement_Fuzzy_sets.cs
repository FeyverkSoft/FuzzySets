using System;
namespace Fuzzy_sets
{
    /// <summary>
    /// Интерфейс Элемента нечёткого множества
    /// </summary>
    public interface IElement_Fuzzy_sets<Tip_Element> where Tip_Element : IComparable<Tip_Element>, IEquatable<Tip_Element>
    {
        /// <summary>
        /// [read only] Возвращает значение функции принадлежности элемента к нечёткому множеству
        /// </summary>
        double Accessory_Function { get; }

        /// <summary>
        /// Возвращает концентрированный элемент нечёткого множества
        /// </summary>
        Element_Fuzzy_sets<Tip_Element> Con { get; }

        /// <summary>
        /// Возвращает растянутый элемент нечёткого множества
        /// </summary>
        Element_Fuzzy_sets<Tip_Element> Dil { get; }

        /// <summary>
        /// [read only] Возвращает элемент нечёткого множества
        /// </summary>
        Tip_Element Element { get; }

        /// <summary>
        /// Переопределение базового сравнения
        /// </summary>
        /// <param name="obj">Объект для сравнения с текущим</param>
        /// <returns>true если равны false иначе</returns>
        bool Equals(object obj);

        /// <summary>
        /// Возвращает хеш-код
        /// </summary>
        /// <returns></returns>
        int GetHashCode();

        /// <summary>
        /// Возвращает строковое представление данного элемента нечеткого множества
        /// </summary>
        /// <returns>Строковое предствавление элемента нечеткого множества</returns>
        string ToString();
    }
}
