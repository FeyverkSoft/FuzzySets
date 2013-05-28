using System;
namespace Fuzzy_sets
{
    /// <summary>
    /// Интерфейс описывающий нечеткое множество
    /// </summary>
    public interface IFuzzy_sets<Tip_Element> where Tip_Element : IComparable<Tip_Element>, IEquatable<Tip_Element>
    {
        /// <summary>
        /// [read only] Возвращает название множества
        /// </summary>
        String Name { get; }

        /// <summary>
        /// Добавляет в нечёткое множество новый элемент.
        /// </summary>
        /// <param name="Element">Элемент нечёткого множества</param>
        void Add(Element_Fuzzy_sets<Tip_Element> Element);

        /// <summary>
        /// Добавляет в нечёткое множество новый элемент.
        /// </summary>
        /// <param name="Element">Элемент нечёткого множества</param>
        /// <param name="Accessory_Function">Значение функции принадлежества элемента к нечёткому множеству</param>
        void Add(Tip_Element Element, double Accessory_Function = 0);

        /// <summary>
        /// Объединение 2х нечетких множеств
        /// </summary>
        /// <param name="a">Первое множество</param>
        /// <param name="b">Второе множество</param>
        /// <returns>Возвращает результат объединения 2х множеств</returns>
        Fuzzy_sets<Tip_Element> Association(Fuzzy_sets<Tip_Element> a, Fuzzy_sets<Tip_Element> b);

        /// <summary>
        /// Возвращает концентрированное нечёткое множество
        /// </summary>
        Fuzzy_sets<Tip_Element> Con { get; }

        /// <summary>
        /// Получает количество элементов в нечётком множестве
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Элемент на текущей позиции
        /// </summary>
        object Current { get; }

        /// <summary>
        /// Удаляет из нечёткого множества указанный элемент.
        /// </summary>
        /// <param name="Element">Элемент нечёткого множества</param>
        void Delete(Element_Fuzzy_sets<Tip_Element> Element);

        /// <summary>
        /// Удаляет из нечёткого множества элемент по указанному индексу.
        /// </summary>
        /// <param name="Index">Индекс элемента нечёткого множества</param>
        void DeleteAt(int Index);

        /// <summary>
        /// Удаляет из нечёткого множества указанный элемент.
        /// </summary>
        /// <param name="Element">Элемент нечёткого множества</param>
        /// <param name="Accessory_Function">Значение функции принадлежества элемента к нечёткому множеству</param>
        void Delete(Tip_Element Element, double Accessory_Function = 0);

        /// <summary>
        /// Возвращает растянутое нечёткое множество
        /// </summary>
        Fuzzy_sets<Tip_Element> Dil { get; }

        /// <summary>
        /// Переопределение базового сравнения
        /// </summary>
        /// <param name="obj">Объект для сравнения с текущим</param>
        /// <returns>true если равны false иначе</returns>
        bool Equals(object obj);

        /// <summary>
        /// Создает и возвращает "перечислитель", позволяющий перебирать в цикле все элементы списка.
        /// </summary>
        /// <returns>возвращает "перечислитель", позволяющий перебирать в цикле все элементы списка.</returns>
        System.Collections.IEnumerator GetEnumerator();

        /// <summary>
        /// Возвращает хеш-код
        /// </summary>
        /// <returns>Возвращает хеш-код нечеткого множества, уникальность не гарантируется</returns>
        int GetHashCode();

        /// <summary>
        /// Возвращает ближайшее чёткое множество к данному
        /// </summary>
        Fuzzy_sets<Tip_Element> Get_Clear_Sets { get; }

        /// <summary>
        /// Вычисляет и возвращает относительный индекс Евклида для данного множества
        /// </summary>
        double Index_of_Euclid { get; }

        /// <summary>
        /// Вычисляет и возвращает линейный индекс Евклида для данного множества
        /// </summary>
        Double Index_of_Euclid_Line { get; }

        /// <summary>
        /// Вычисляет и возвращает относительный индекс Хемминга для данного множества
        /// </summary>
        double Index_of_Hamming { get; }

        /// <summary>
        /// Вычисляет и возвращает Линейный индекс Хемминга для данного множества
        /// </summary>
        Double Index_of_Hamming_Line { get; }

        /// <summary>
        /// Пересечение 2х нечетких множеств
        /// </summary>
        /// <param name="a">Первое множество</param>
        /// <param name="b">Второе множество</param>
        /// <returns>Возвращает результат пересечения 2х множеств</returns>
        Fuzzy_sets<Tip_Element> Intersection(Fuzzy_sets<Tip_Element> a, Fuzzy_sets<Tip_Element> b);

        /// <summary>
        /// Сдвинуть счетчик на +1 и если индекс не превысил допустимый вернуть true
        /// </summary>
        /// <returns></returns>
        bool MoveNext();

        /// <summary>
        /// Сброс счетчика
        /// </summary>
        void Reset();

        /// <summary>
        /// Возвращает отсортированное по Функции принадлежности  в порядке возрастания нечеткое множество
        /// </summary>
        Fuzzy_sets<Tip_Element> Sort_from_Accessory_Function { get; }

        /// <summary>
        /// Возвращает отсортированное по Элементу в порядке возрастания принадлежности нечеткое множество
        /// </summary>
        Fuzzy_sets<Tip_Element> Sort_from_Element { get; }

        /// <summary>
        /// [Желательно Read only] Возвращает или задаёт элемент по указанному индексу
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        Element_Fuzzy_sets<Tip_Element> this[int i] { get; set; }

        /// <summary>
        /// Возвращает строковое представление нечеткого множества;
        /// </summary>
        /// <returns>Возвращает строковое представление нечеткого множества;</returns>
        string ToString();
    }
}
