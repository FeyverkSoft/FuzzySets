using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy_sets
{
    /// <summary>
    /// Класс сортирующий нечёткие множества
    /// </summary>
    class sort<Tip_Element> where Tip_Element : System.IComparable<Tip_Element>, IEquatable<Tip_Element>
    {
        /// <summary>
        /// Сортировка нечёткого множества по значению элемента множества
        /// </summary>
        /// <param name="A">Нечёткое множество</param>
        /// <param name="low">Начальный элемент</param>
        /// <param name="high">Конечный элемент</param>
        public static Fuzzy_sets<Tip_Element> qSort_from_Element(Fuzzy_sets<Tip_Element> A, int low = 0, int high = 0)
        {
            int i = low;
            int j = high;
            Element_Fuzzy_sets<Tip_Element> x = A[(low + high) / 2];  // x - опорный элемент посредине между low и high
            do
            {
                while (A[i].Element.CompareTo(x.Element) < 0) ++i;  // поиск элемента для переноса в старшую часть
                while (A[j].Element.CompareTo(x.Element) > 0) --j;  // поиск элемента для переноса в младшую часть
                if (i <= j)
                {
                    // обмен элементов местами:
                    Element_Fuzzy_sets<Tip_Element> temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                    // переход к следующим элементам:
                    i++; j--;
                }
            } while (i < j);
            if (low < j) qSort_from_Element(A, low, j);
            if (i < high) qSort_from_Element(A, i, high);
            return A;
        }

        /// <summary>
        /// Сортировка нечёткого множества по значению функции принадлежности элемента множеству
        /// </summary>
        /// <param name="A">Нечёткое множество</param>
        /// <param name="low">Начальный элемент</param>
        /// <param name="high">Конечный элемент</param>
        public static Fuzzy_sets<Tip_Element> qSort_from_Accessory_Function(Fuzzy_sets<Tip_Element> A, int low = 0, int high = 0)
        {
            int i = low;
            int j = high;
            Element_Fuzzy_sets<Tip_Element> x = A[(low + high) / 2];  // x - опорный элемент посредине между low и high
            do
            {
                while (A[i].Accessory_Function < x.Accessory_Function) ++i;  // поиск элемента для переноса в старшую часть
                while (A[j].Accessory_Function > x.Accessory_Function) --j;  // поиск элемента для переноса в младшую часть
                if (i <= j)
                {
                    // обмен элементов местами:
                    Element_Fuzzy_sets<Tip_Element> temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                    // переход к следующим элементам:
                    i++; j--;
                }
            } while (i < j);
            if (low < j) qSort_from_Accessory_Function(A, low, j);
            if (i < high) qSort_from_Accessory_Function(A, i, high);
            return A;
        }
    }

    /// <summary>
    /// Элемент нечёткого множества
    /// </summary>
    public class Element_Fuzzy_sets<Tip_Element> : Fuzzy_sets.IElement_Fuzzy_sets<Tip_Element> where Tip_Element : System.IComparable<Tip_Element>, IEquatable<Tip_Element>
    {
        #region Переменные класса
        /// <summary>
        /// Элемент множества
        /// </summary>
        fuzzu element = new fuzzu();
        #endregion

        #region Структуры класса
        /// <summary>
        /// структура описывающая 1 элемент нечёткого множества
        /// </summary>
        struct fuzzu
        {
            Tip_Element element;//элемент множества
            Double accessory_Function;//функция принадлежности элемента, данному множеству (от 0 до 1)
            /// <summary>
            /// Элемент нечеткого множества
            /// </summary>
            public Tip_Element Element
            {
                get { return element; }
                set { element = value; }
            }
            /// <summary>
            /// функция принадлежности элемента, данному множеству (от 0 до 1)
            /// </summary>
            public Double Accessory_Function
            {
                get { return accessory_Function; }//если не null тогда возвращаем значение, иначе 0
                set { accessory_Function = value; }//присваиваем значение
            }
        }
        #endregion

        #region Свойства класса

        /// <summary>
        /// [read only] Возвращает значение функции принадлежности элемента к нечёткому множеству
        /// </summary>
        public Double Accessory_Function
        {
            get { return element.Accessory_Function; }
        }

        /// <summary>
        /// [read only] Возвращает элемент нечёткого множества
        /// </summary>
        public Tip_Element Element
        {
            get { return element.Element; }
        }

        /// <summary>
        /// Возвращает растянутый элемент нечёткого множества
        /// </summary>
        public Element_Fuzzy_sets<Tip_Element> Dil
        {
            get
            {
                return new Element_Fuzzy_sets<Tip_Element>(element.Element, Math.Sqrt(element.Accessory_Function));
            }
        }

        /// <summary>
        /// Возвращает концентрированный элемент нечёткого множества
        /// </summary>
        public Element_Fuzzy_sets<Tip_Element> Con
        {
            get
            {
                return new Element_Fuzzy_sets<Tip_Element>(element.Element, element.Accessory_Function * element.Accessory_Function);
            }
        }

        #endregion

        #region Функции класса
        /// <summary>
        /// Конструктор, принимает элемент множества, и функцию принадлежности
        /// </summary>
        /// <param name="Element">Элемент множества</param>
        /// <param name="Accessory_Function">Функция принадлежности</param>
        public Element_Fuzzy_sets(Tip_Element Element, Double Accessory_Function = 0)
        {
            element.Element = Element;//присваиваем элементу значение
            element.Accessory_Function = Accessory_Function;//присваиваем функции принадлежности значение
        }

        /// <summary>
        /// Возвращает хеш-код
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (Accessory_Function + " " + Element).GetHashCode();
        }

        /// <summary>
        /// Переопределение базового сравнения
        /// </summary>
        /// <param name="obj">Объект для сравнения с текущим</param>
        /// <returns>true если равны false иначе</returns>
        public override bool Equals(System.Object obj)
        {
            Element_Fuzzy_sets<Tip_Element> p = obj as Element_Fuzzy_sets<Tip_Element>;
            if ((System.Object)p == null || obj == null)
            {
                return false;
            }
            return (Element.CompareTo(p.Element) == 0) && (Accessory_Function == p.Accessory_Function);
        }

        /// <summary>
        /// Возвращает строковое представление данного элемента нечеткого множества
        /// </summary>
        /// <returns>Строковое предствавление элемента нечеткого множества</returns>
        public override string ToString()
        {
            return Accessory_Function.ToString() + "/" + Element.ToString();
        }
        #endregion

        #region Операторы класса
        /// <summary>
        /// Сравнивает 2 элемента множества, и если они РАВНЫ возвращает true в противном случае false 
        /// </summary>
        /// <param name="a">Первый элемент для сравнения</param>
        /// <param name="b">Второй элемент для сравнения</param>
        /// <returns>Если элементы равны true иначе false</returns>
        public static Boolean operator ==(Element_Fuzzy_sets<Tip_Element> a, Element_Fuzzy_sets<Tip_Element> b)
        {
            if ((Object)a == null & (Object)b == null)//проверить на null
                return true;

            if ((Object)a == null || (Object)b == null)//проверить на null
                return false;
            return ((a.Element.CompareTo(b.Element) == 0) && (a.Accessory_Function == b.Accessory_Function));
        }

        /// <summary>
        /// Сравнивает 2 элемента множества, и если они НЕ РАВНЫ возвращает true в противном случае false 
        /// </summary>
        /// <param name="a">Первый элемент для сравнения</param>
        /// <param name="b">Второй элемент для сравнения</param>
        /// <returns>Если элементы НЕ РАВНЫ true иначе false</returns>
        public static Boolean operator !=(Element_Fuzzy_sets<Tip_Element> a, Element_Fuzzy_sets<Tip_Element> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Отрицает элемент нечёткого множества
        /// </summary>
        /// <param name="a">Элемент для отрицания</param>
        /// <returns>Возвращает обратный элемент данному</returns>
        public static Element_Fuzzy_sets<Tip_Element> operator !(Element_Fuzzy_sets<Tip_Element> a)
        {
            return new Element_Fuzzy_sets<Tip_Element>(a.Element, 1 - a.Accessory_Function);
        }
        #endregion
    }

    /// <summary>
    /// Класс описывающий нечеткое множество
    /// </summary>
    public class Fuzzy_sets<Tip_Element> : IEnumerator, IEnumerable, Fuzzy_sets.IFuzzy_sets<Tip_Element> where Tip_Element : System.IComparable<Tip_Element>, IEquatable<Tip_Element>
    {
        #region Переменные класса
        /// <summary>
        /// Список элементов нечеткого множества
        /// </summary>
        List<Element_Fuzzy_sets<Tip_Element>> Mass = new List<Element_Fuzzy_sets<Tip_Element>>();
        /// <summary>
        /// Название множества если нужно
        /// </summary>
        String name = "";
        int position = -1;//текущая позиция для реализации IEnumerator, IEnumerable
        #endregion

        #region Реализация интерфейсов IEnumerator, IEnumerable
        /// <summary>
        /// Создает и возвращает "перечислитель", позволяющий перебирать в цикле все элементы списка.
        /// </summary>
        /// <returns>возвращает "перечислитель", позволяющий перебирать в цикле все элементы списка.</returns>
        public IEnumerator GetEnumerator()
        {
            position = -1;
            return (IEnumerator)this;
        }

        /// <summary>
        /// Элемент на текущей позиции
        /// </summary>
        public object Current
        {
            get { return Mass[position]; }
        }

        /// <summary>
        /// Сдвинуть счетчик на +1 и если индекс не превысил допустимый вернуть true
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            position++;
            return (position < Count);
        }

        /// <summary>
        /// Сброс счетчика
        /// </summary>
        public void Reset()
        {
            position = 0;
        }
        #endregion

        #region Свойства класса

        /// <summary>
        /// [read only] Возвращает название множества
        /// </summary>
        public String Name
        {
            get { return name; }
        }

        /// <summary>
        /// [Желательно Read only] Возвращает или задаёт элемент по указанному индексу
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Element_Fuzzy_sets<Tip_Element> this[Int32 i]
        {
            get { return Mass[i]; }
            set { Mass[i] = value; }
        }

        /// <summary>
        /// Получает количество элементов в нечётком множестве
        /// </summary>
        public Int32 Count
        {
            get { return Mass.Count; }
        }

        /// <summary>
        /// Возвращает растянутое нечёткое множество
        /// </summary>
        public Fuzzy_sets<Tip_Element> Dil
        {
            get
            {
                Fuzzy_sets<Tip_Element> _temp = new Fuzzy_sets<Tip_Element>();//Концентрированное множество
                foreach (Element_Fuzzy_sets<Tip_Element> e in Mass)
                    _temp.Mass.Add(e.Dil);
                return _temp;
            }
        }

        /// <summary>
        /// Возвращает концентрированное нечёткое множество
        /// </summary>
        public Fuzzy_sets<Tip_Element> Con
        {
            get
            {
                Fuzzy_sets<Tip_Element> _temp = new Fuzzy_sets<Tip_Element>();//Концентрированное множество
                foreach (Element_Fuzzy_sets<Tip_Element> e in Mass)
                    _temp.Mass.Add(e.Con);
                return _temp;
            }
        }

        /// <summary>
        /// Вычисляет и возвращает относительный индекс Евклида для данного множества
        /// </summary>
        public Double Index_of_Euclid
        {
            get
            {
                Double Index = 0;//объявляем переменную индекса; И инициализируем её нулём;
                foreach (Element_Fuzzy_sets<Tip_Element> e in this.Mass)
                {
                    if (e.Accessory_Function > 0.5)//Если индекс больше 0.5
                    {
                        Index += ((!e).Accessory_Function) * ((!e).Accessory_Function);//когда больше берем отрицание и в квадрат
                    }
                    else
                    {
                        Index += ((e).Accessory_Function) * ((e).Accessory_Function);//меньше без отрицания и в квадрат
                    }
                }
                return (2 / Math.Sqrt(this.Count)) * Math.Sqrt(Index);//ответ
            }
        }

        /// <summary>
        /// Вычисляет и возвращает линейный индекс Евклида для данного множества
        /// </summary>
        public Double Index_of_Euclid_Line
        {
            get
            {
                //////////////Надо дописать!!!
                return 0;//ответ
            }
        }

        /// <summary>
        /// Вычисляет и возвращает относительный индекс Хемминга для данного множества
        /// </summary>
        public Double Index_of_Hamming
        {
            get
            {
                Double Index = 0;//объявляем переменную индекса; И инициализируем её нулём;
                foreach (Element_Fuzzy_sets<Tip_Element> e in this.Mass)
                {
                    if (e.Accessory_Function > 0.5)//Если индекс больше 0.5
                    {
                        Index += (!e).Accessory_Function;//когда больше берем отрицание
                    }
                    else
                    {
                        Index += (e).Accessory_Function;//меньше без отрицания
                    }
                }
                return (2d / this.Count) * Index;//ответ
            }
        }

        /// <summary>
        /// Вычисляет и возвращает Линейный индекс Хемминга для данного множества
        /// </summary>
        public Double Index_of_Hamming_Line
        {
            get
            {
                Double Index = 0;//объявляем переменную индекса; И инициализируем её нулём;
                foreach (Element_Fuzzy_sets<Tip_Element> e in this.Mass)
                {
                    if (e.Accessory_Function > 0.5)//Если индекс больше 0.5
                    {
                        Index += (!e).Accessory_Function;//когда больше берем отрицание
                    }
                    else
                    {
                        Index += (e).Accessory_Function;//меньше без отрицания
                    }
                }
                return Index;//ответ
            }
        }

        /// <summary>
        /// Возвращает отсортированное по Функции принадлежности  в порядке возрастания нечеткое множество
        /// </summary>
        public Fuzzy_sets<Tip_Element> Sort_from_Accessory_Function
        {
            get
            {
                return sort<Tip_Element>.qSort_from_Accessory_Function(this, 0, (this.Count - 1));
            }
        }

        /// <summary>
        /// Возвращает отсортированное по Элементу в порядке возрастания принадлежности нечеткое множество
        /// </summary>
        public Fuzzy_sets<Tip_Element> Sort_from_Element
        {
            get
            {
                return sort<Tip_Element>.qSort_from_Element(this, 0, (this.Count - 1));
            }
        }

        /// <summary>
        /// Возвращает ближайшее чёткое множество к данному
        /// </summary>
        public Fuzzy_sets<Tip_Element> Get_Clear_Sets
        {
            get
            {
                Fuzzy_sets<Tip_Element> _Temp = new Fuzzy_sets<Tip_Element>();
                foreach (Element_Fuzzy_sets<Tip_Element> t in Mass)
                    if (t.Accessory_Function > 0.5)
                        _Temp.Add(t.Element, 1);
                    else
                        _Temp.Add(t.Element);
                return _Temp;
            }
        }
        #endregion

        #region Функции класса

        /// <summary>
        /// Конструктор нечеткого множества
        /// </summary>
        /// <param name="Name">Название множества, по умолчанию пустое</param>
        public Fuzzy_sets(String Name = "")
        {
            name = Name;
        }

        /// <summary>
        /// Конструктор нечеткого множества
        /// </summary>
        /// <param name="Name">Название множества, по умолчанию пустое</param>
        /// <param name="Sets">Нечеткое множество на основе которого будет построенно данное множество</param>
        public Fuzzy_sets(Fuzzy_sets<Tip_Element> Sets, String Name = "")
        {
            Mass = Sets.Mass;
            name = Name;
        }

        /// <summary>
        /// Конструктор нечеткого множества
        /// </summary>
        /// <param name="Name">Название множества, по умолчанию пустое</param>
        /// <param name="List_Element_Sets">Список элементов нечеткого множества</param>
        public Fuzzy_sets(List<Element_Fuzzy_sets<Tip_Element>> List_Element_Sets, String Name = "")
        {
            foreach (Element_Fuzzy_sets<Tip_Element> e in List_Element_Sets)
                this.Add(e);
            name = Name;
        }

        /// <summary>
        /// Конструктор нечеткого множества
        /// </summary>
        /// <param name="Name">Название множества, по умолчанию пустое</param>
        /// <param name="List_Element_Sets">Массив элементов нечеткого множества</param>
        public Fuzzy_sets(Element_Fuzzy_sets<Tip_Element>[] List_Element_Sets, String Name = "")
        {
            foreach (Element_Fuzzy_sets<Tip_Element> e in List_Element_Sets)
                this.Add(e);
            name = Name;
        }

        /// <summary>
        /// Добавляет в нечёткое множество новый элемент.
        /// </summary>
        /// <param name="Element">Элемент нечёткого множества</param>
        public void Add(Element_Fuzzy_sets<Tip_Element> Element)
        {
            if (Mass == null)//если множество не объявлено, объявляем его
                Mass = new List<Element_Fuzzy_sets<Tip_Element>>();

            if (!Mass.Contains(Element))//если такого элемента еще в множестве нету
                Mass.Add(Element);//добавляем элемент
        }

        /// <summary>
        /// Добавляет в нечёткое множество новый элемент.
        /// </summary>
        /// <param name="Element">Элемент нечёткого множества</param>
        /// <param name="Accessory_Function">Значение функции принадлежества элемента к нечёткому множеству</param>
        public void Add(Tip_Element Element, Double Accessory_Function = 0)
        {
            if (Mass == null)//если множество не объявлено, объявляем его
                Mass = new List<Element_Fuzzy_sets<Tip_Element>>();

            if (!Mass.Contains(new Element_Fuzzy_sets<Tip_Element>(Element, Accessory_Function)))//если такого элемента еще в множестве нету
                Mass.Add(new Element_Fuzzy_sets<Tip_Element>(Element, Accessory_Function));//добавляем элемент
        }

        /// <summary>
        /// Удаляет из нечёткого множества указанный элемент.
        /// </summary>
        /// <param name="Element">Элемент нечёткого множества</param>
        public void Delete(Element_Fuzzy_sets<Tip_Element> Element)
        {
            if (Mass == null)//если множество не объявлено, объявляем его
                Mass = new List<Element_Fuzzy_sets<Tip_Element>>();

            if (Mass.Contains(Element))//если такого элемента еще в множестве нету
                Mass.Remove(Element);//добавляем элемент
        }

        /// <summary>
        /// Удаляет из нечёткого множества указанный элемент.
        /// </summary>
        /// <param name="Element">Элемент нечёткого множества</param>
        /// <param name="Accessory_Function">Значение функции принадлежества элемента к нечёткому множеству</param>
        public void Delete(Tip_Element Element, Double Accessory_Function = 0)
        {
            if (Mass == null)//если множество не объявлено, объявляем его
                Mass = new List<Element_Fuzzy_sets<Tip_Element>>();

            if (Mass.Contains(new Element_Fuzzy_sets<Tip_Element>(Element, Accessory_Function)))//если такой элемент в множестве есь
                Mass.Remove(new Element_Fuzzy_sets<Tip_Element>(Element, Accessory_Function));//удаляем элемент
        }

        /// <summary>
        /// Удаляет из нечёткого множества элемент по указанному индексу.
        /// </summary>
        /// <param name="Index">Индекс элемента нечёткого множества</param>
        public void DeleteAt(int Index)
        {
            if (Mass == null)//если множество не объявлено, объявляем его
                Mass = new List<Element_Fuzzy_sets<Tip_Element>>();
            if (Index < Count && Index >= 0)
                Mass.RemoveAt(Index);
        }

        /// <summary>
        /// Возвращает хеш-код
        /// </summary>
        /// <returns>Возвращает хеш-код нечеткого множества, уникальность не гарантируется</returns>
        public override int GetHashCode()
        {
            return Mass.GetHashCode();
        }

        /// <summary>
        /// Переопределение базового сравнения
        /// </summary>
        /// <param name="obj">Объект для сравнения с текущим</param>
        /// <returns>true если равны false иначе</returns>
        public override bool Equals(System.Object obj)
        {
            Fuzzy_sets<Tip_Element> p = obj as Fuzzy_sets<Tip_Element>;
            if ((System.Object)p == null || obj == null)
            {
                return false;
            }
            return (Mass == p.Mass);
        }

        /// <summary>
        /// Возвращает строковое представление нечеткого множества;
        /// </summary>
        /// <returns>Возвращает строковое представление нечеткого множества;</returns>
        public override string ToString()
        {
            String s = "";
            Int32 D = Count;
            for (Int32 i = 0; i < D; i++)
            {
                if (i < D - 1)
                {
                    s += Mass[i].ToString() + " + ";
                }
                else
                {
                    s += Mass[i].ToString();
                }
            }
            return Name + "=" + s;
        }
        #endregion

        #region Операторы класса
        /// <summary>
        /// Сравнивает 2 нечётких множества, и если они РАВНЫ возвращает true в противном случае false 
        /// </summary>
        /// <param name="a">Первое нечёткое множество</param>
        /// <param name="b">Второе нечёткое множество</param>
        /// <returns>Если элементы РАВНЫ true иначе false</returns>
        public static Boolean operator ==(Fuzzy_sets<Tip_Element> a, Fuzzy_sets<Tip_Element> b)
        {
            if ((Object)a == null & (Object)b == null)//проверить на null
                return true;

            if ((Object)a == null || (Object)b == null)//проверить на null
                return false;

            if (a.Count != b.Count)
                return false;

            Fuzzy_sets<Tip_Element> A = a.Sort_from_Element;//отсортированное по элементам множество a
            Fuzzy_sets<Tip_Element> B = b.Sort_from_Element;//отсортированное по элементам множество b
            for (int i = 0; i < a.Count; i++)
                if (A[i] != B[i])
                    return false;
            return true;
        }

        /// <summary>
        /// Сравнивает 2 нечётких множества, и если они НЕ РАВНЫ возвращает true в противном случае false 
        /// </summary>
        /// <param name="a">Первое нечёткое множество</param>
        /// <param name="b">Второе нечёткое множество</param>
        /// <returns>Если элементы НЕ РАВНЫ true иначе false</returns>
        public static Boolean operator !=(Fuzzy_sets<Tip_Element> a, Fuzzy_sets<Tip_Element> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Отрицает нечёткое множество
        /// </summary>
        /// <param name="a">Множество для отрицания</param>
        /// <returns>Возвращает множество обратное данному</returns>
        public static Fuzzy_sets<Tip_Element> operator !(Fuzzy_sets<Tip_Element> a)
        {
            Fuzzy_sets<Tip_Element> _Temp = new Fuzzy_sets<Tip_Element>();
            foreach (Element_Fuzzy_sets<Tip_Element> e in a)
                _Temp.Add(!e);
            return _Temp;
        }

        /// <summary>
        /// Объединение 2х нечетких множеств
        /// </summary>
        /// <param name="a">Первое множество</param>
        /// <param name="b">Второе множество</param>
        /// <returns>Возвращает результат объединения 2х множеств</returns>
        public static Fuzzy_sets<Tip_Element> operator +(Fuzzy_sets<Tip_Element> a, Fuzzy_sets<Tip_Element> b)
        {
            Fuzzy_sets<Tip_Element> _Temp = new Fuzzy_sets<Tip_Element>();//новое нечёткое множество
            foreach (Element_Fuzzy_sets<Tip_Element> e1 in a)
            {
                bool flag = true;
                foreach (Element_Fuzzy_sets<Tip_Element> e2 in b)
                    if (e1.Element.CompareTo(e2.Element) == 0)//если элементы равны
                    {
                        _Temp.Add((e1.Accessory_Function >= e2.Accessory_Function) ? e1 : e2);//выбираем элемент с наибольшим значением функции принадлежности
                        flag = false; break;
                    }
                if (flag)
                    _Temp.Add(e1);
            }

            foreach (Element_Fuzzy_sets<Tip_Element> e1 in b)
            {
                bool flag = true;
                foreach (Element_Fuzzy_sets<Tip_Element> e2 in _Temp)
                {
                    if (e1.Element.CompareTo(e2.Element) == 0)
                    {
                        flag = false; break;
                    }
                }
                if (flag)
                    _Temp.Add(e1);
            }
            return _Temp;
        }

        /// <summary>
        /// Пересечение 2х нечетких множеств
        /// </summary>
        /// <param name="a">Первое множество</param>
        /// <param name="b">Второе множество</param>
        /// <returns>Возвращает результат пересечения 2х множеств</returns>
        public static Fuzzy_sets<Tip_Element> operator /(Fuzzy_sets<Tip_Element> a, Fuzzy_sets<Tip_Element> b)
        {
            Fuzzy_sets<Tip_Element> _Temp = new Fuzzy_sets<Tip_Element>();//новое нечёткое множество
            foreach (Element_Fuzzy_sets<Tip_Element> e1 in a)
            {
                bool flag = true;
                foreach (Element_Fuzzy_sets<Tip_Element> e2 in b)
                    if (e1.Element.CompareTo(e2.Element) == 0)//если элементы равны
                    {
                        _Temp.Add((e1.Accessory_Function <= e2.Accessory_Function) ? e1 : e2);//выбираем элемент с наименьшим значением функции принадлежности
                        flag = false; break;
                    }
                if (flag)
                    _Temp.Add(new Element_Fuzzy_sets<Tip_Element>(e1.Element, 0));
            }

            foreach (Element_Fuzzy_sets<Tip_Element> e1 in b)
            {
                bool flag = true;
                foreach (Element_Fuzzy_sets<Tip_Element> e2 in _Temp)
                {
                    if (e1.Element.CompareTo(e2.Element) == 0)
                    {
                        flag = false; break;
                    }
                }
                if (flag)
                    _Temp.Add(new Element_Fuzzy_sets<Tip_Element>(e1.Element, 0));
            }
            return _Temp;
        }
        #endregion

        #region Перегрузки-заглушки операторов

        /// <summary>
        /// Объединение 2х нечетких множеств
        /// </summary>
        /// <param name="a">Первое множество</param>
        /// <param name="b">Второе множество</param>
        /// <returns>Возвращает результат объединения 2х множеств</returns>
        public Fuzzy_sets<Tip_Element> Association(Fuzzy_sets<Tip_Element> a, Fuzzy_sets<Tip_Element> b)
        {
            return a + b;
        }

        /// <summary>
        /// Пересечение 2х нечетких множеств
        /// </summary>
        /// <param name="a">Первое множество</param>
        /// <param name="b">Второе множество</param>
        /// <returns>Возвращает результат пересечения 2х множеств</returns>
        public Fuzzy_sets<Tip_Element> Intersection(Fuzzy_sets<Tip_Element> a, Fuzzy_sets<Tip_Element> b)
        {
            return a / b;
        }
        #endregion

        #region Статические методы класса и статические перегрузки
        /// <summary>
        /// Возвращает концентрацию указанного множества. Рекомендуется использовать Свойство Con у самого множества, а не данную функцию
        /// </summary>
        /// <param name="a">Множество для взятия концентрации.</param>
        /// <returns>Возвращает концентрацию множества </returns>
        public static Fuzzy_sets<Tip_Element> Get_Concentration(Fuzzy_sets<Tip_Element> a)
        {
            return a.Con;
        }

        /// <summary>
        /// Возвращает растяжение указанного множества. Рекомендуется использовать Свойство Dil у самого множества, а не данную функцию
        /// </summary>
        /// <param name="a">Множество для взятия Растяжения.</param>
        /// <returns>Возвращает растяжение множества </returns>
        public static Fuzzy_sets<Tip_Element> Get_Dilation(Fuzzy_sets<Tip_Element> a)
        {
            return a.Dil;
        }

        /// <summary>
        /// Возвращает индекс Евклида указанного множества. Рекомендуется использовать Свойство Index_of_Euclid у самого множества, а не данную функцию
        /// </summary>
        /// <param name="a">Множество для вычисления индекса Евклида.</param>
        /// <returns>Возвращает индекс Евклида для заданного множества</returns>
        public static Double Get_Index_Euclid(Fuzzy_sets<Tip_Element> a)
        {
            return a.Index_of_Euclid;
        }

        /// <summary>
        /// Возвращает индекс Хемминга указанного множества. Рекомендуется использовать Свойство Index_of_Hamming у самого множества, а не данную функцию
        /// </summary>
        /// <param name="a">Множество для вычисления индекса Хемминга.</param>
        /// <returns>Возвращает индекс Хеммигда для заданного множества </returns>
        public static Double Get_Index_Hamming(Fuzzy_sets<Tip_Element> a)
        {
            return a.Index_of_Euclid;
        }

        /// <summary>
        /// Возвращает отсортированное нечеткое множество в порядке возрастания функции нечеткости.
        /// </summary>
        /// <param name="a">Множество для сортировки.</param>
        /// <returns>Возвращает отсортированное нечеткое множество в порядке возрастания функции нечеткости.</returns>
        public static Fuzzy_sets<Tip_Element> Sort_Accessory_Function(Fuzzy_sets<Tip_Element> a)
        {
            return a.Sort_from_Accessory_Function;
        }

        /// <summary>
        /// Возвращает отсортированное нечеткое множество в порядке возрастания элементов нечеткого множества.
        /// </summary>
        /// <param name="a">Множество для сортировки.</param>
        /// <returns>Возвращает отсортированное нечеткое множество в порядке возрастания элементов нечеткого множества..</returns>
        public static Fuzzy_sets<Tip_Element> Sort_Element(Fuzzy_sets<Tip_Element> a)
        {
            return a.Sort_from_Element;
        }

        /// <summary>
        /// Возвращает ближайшее четкое множество к указанному не чёткому
        /// </summary>
        /// <param name="a">Множество для взятия четкого множества.</param>
        /// <returns>Возвращает ближайшее четкое множество к указанному не чёткому</returns>
        public static Fuzzy_sets<Tip_Element> Return_Clear_Sets(Fuzzy_sets<Tip_Element> a)
        {
            return a.Get_Clear_Sets;
        }
        #endregion
    }
}
