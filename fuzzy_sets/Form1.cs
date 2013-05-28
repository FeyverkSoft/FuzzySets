using System;
using System.Collections.Generic;
using System.Reflection;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fuzzy_sets;
using System.Text.RegularExpressions;
using System.Collections;
using System.IO;

namespace fuzzy_sets_GUI
{
    public partial class Form1 : Form
    {

        BindingList<Fuzzy_sets<Double>> Mass = new BindingList<Fuzzy_sets<Double>>();

        public Form1(string[] args)
        {
            InitializeComponent();
            if (args.Length > 0)
            {
                if (System.IO.File.Exists(args[0]))
                    Read_From_File(args[0]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Version_label.Text += Assembly.GetExecutingAssembly().GetName().Version.ToString(); ;
            Readed_listBox.DataSource = Mass;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Переводит строковое представление универсума в виде списка отдельных элементов
        /// </summary>
        /// <param name="text">Входная строка формата {элемент;элемент;элемент}</param>
        /// <returns></returns>
        List<Double> Read_Universum(String text)
        {
            List<Double> Universum = new List<Double>();//список элементов универсального множества
            text = text.Replace(" ", "").Replace("\n", "").Replace("\r", "").Replace("\t", "").Replace(".", ",");
            String element = "";
            for (Int32 i = 1; i < text.Length - 1; i++)
            {
                if (text[i] != ';')
                    element += text[i];
                else
                {
                    Universum.Add(Convert.ToDouble(element));
                    element = "";
                }
            }
            Double el = 0;
            if (Double.TryParse(element, out el))//добавляю последний если остался
                Universum.Add(el);

            return Universum;
        }

        /// <summary>
        /// Преобразует указанную строку в нечеткое множество
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        Fuzzy_sets<Double> ConvertTo_Fuzzy_Sets(String s)
        {
            String[] Name_F = s.Split('=');//отделяем название от описания
            Error_Log_textBox.Text += "[info] Распознаём: \"" + Name_F[0] + "\"\r\n";//логи
            if (Name_F.Length != 2)//если длинна не 2 элемента, 0 элемент это имя множества, 1 элемент строка с описанием множества
            {
                Error_Log_textBox.Text += "[Ошибка] Неверный синтаксис описания множества: \"" + Name_F[0] + "\"\r\n";//логи
                return null;
            }

            String[] Fuzzu_elem = Name_F[1].Split('+');//режем строку с описанием множества по плюсам
            Fuzzy_sets<Double> _F_Temp = new Fuzzy_sets<Double>(Name_F[0]);//текущее создаваемое нечёткое множество
            foreach (String el in Fuzzu_elem)//добавляем все элементы множества
            {
                _F_Temp.Add(Convert.ToDouble(el.Split('/')[1]), Convert.ToDouble(el.Split('/')[0]));
            }
            return _F_Temp;
        }

        /// <summary>
        /// Считываем и распознаём множества из строкового представления
        /// </summary>
        /// <param name="text">Входная строка</param>
        public void read(String text)
        {
            Mass.Clear();//очищаем предыдущее чтение
            Error_Log_textBox.Text += "[info] Начали распознавание множеств. ";//логи
            String[] _Temp = text.Replace(" ", "").Replace("\n", "").Replace("\r", "").Replace("\t", "").Replace(".", ",").Split(';');//режем по строчкам множеств
            Error_Log_textBox.Text += "Предположительное количество: " + _Temp.Length + "\r\n";//логи
            foreach (String s in _Temp)//пробегаем
            {
                try//отлов исключений и ошибок, {самая забагованная часть кода :D}
                {
                    Fuzzy_sets<Double> _F_Temp = ConvertTo_Fuzzy_Sets(s);//преобразуем строку в нечёткое
                    if (_F_Temp == null)
                        break;

                    #region Добавление недостающих элементов из унивёрсума

                    List<Double> Universum = Read_Universum(Universal.Text);//универсальное множество

                    foreach (var u in Universum)//Добавляем те элементы которые были в универсальном но неоказались в нашем множестве
                    {
                        bool flag = false;
                        foreach (Element_Fuzzy_sets<Double> _F in _F_Temp)
                            if (_F.Element == u)
                            {
                                flag = true;
                                break;
                            }
                        if (!flag)
                            _F_Temp.Add(u);
                    }
                    #endregion

                    Mass.Add(new Fuzzy_sets<Double>(_F_Temp, _F_Temp.Name));
                    Error_Log_textBox.Text += "[info] Множество: \"" + _F_Temp.Name + "\" распознано \r\n";//логи
                }
                catch (System.Exception ex)
                {
                    Error_Log_textBox.Text += "[Ошибка] " + ex.Message + " произошла на \"" + s + "\" \r\n";//логи
                }
            }
            Error_Log_textBox.Text += "[info] Распознано: " + Mass.Count + " из " + _Temp.Length + "\r\n";//логи
        }

        /// <summary>
        /// Производит обработку разбиение вычислений
        /// </summary>
        /// <param name="text">Список функций и вычислений</param>
        public void SplitCalculate(String text)
        {
            try
            {
                Result_listBox.Items.Clear();
                Error_Log_textBox.Text += "[info] Начали оптимизацию выражений. \r\n";//логи
                String _S = Instructions_textBox.Text.Replace("Hemming", "hemming").Replace("Euclid", "euclid").Replace("Clearset", "clearset").Replace("LineEuclid", "lineeuclid").Replace("LineHemming", "linehemming").Replace("Lineeuclid", "lineeuclid").Replace("Linehemming", "linehemming");
                String[] NewOperators = { "con", "dil" };//Новые операторы на которые будут заменены вхождения старых
                String[] OldOperators = { "CON", "COn", "Con", "cON", "coN", "cOn", "CoN", "DIL", "DIl", "Dil", "dIL", "diL", "dIl", "DiL" };//старые операторы, которые будут заменены новыми
                for (Int32 i = 0; i < NewOperators.Length; i++)
                    for (Int32 j = i * (OldOperators.Length / NewOperators.Length); j < (i + 1) * (OldOperators.Length / NewOperators.Length); j++)
                        _S = _S.Replace(OldOperators[j], NewOperators[i]);
                Error_Log_textBox.Text += "[info] Оптимизация завершена \r\n";//логи

                Error_Log_textBox.Text += "[info] Начали распознавание действий над множествами. ";//логи
                String[] _Temp = _S.Replace(" ", "").Replace("\n", "").Replace("\r", "").Replace("\t", "").Replace(".", ",").Split(';');//режем по строчкам множеств
                Error_Log_textBox.Text += "Предположительное число инструкций: " + _Temp.Length + "\r\n";//логи

                List<String> Poliz = new List<String>();
                Error_Log_textBox.Text += "[info] Начали преобразование выражений \r\n";//логи
                for (Int32 i = 0; i < _Temp.Length; i++)
                {
                    try
                    {
                        Poliz.Add(MyRevers(_Temp[i]));
                        Error_Log_textBox.Text += Poliz[i] + "\r\n";
                    }
                    catch { };
                }
                Error_Log_textBox.Text += "[info] Преобразования завершены \r\n[info] Начинаем расчёт\r\n";//логи
                for (int i = 0; i < Poliz.Count; i++)
                {
                    Result_listBox.Items.Add(Calculate(Poliz[i], _Temp[i]));//считаем выражение и пишем ответ
                    Result_listBox.SelectedIndex = i;
                }
            }
            catch (System.Exception ex)
            {
                Error_Log_textBox.Text += "[Предупреждение] " + ex.Message + "\r\n";//логи
            }

        }

        /// <summary>
        /// Считает результаты 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        public String Calculate(String text, String Name = "")
        {
            Stack<Fuzzy_sets<Double>> stack = new Stack<Fuzzy_sets<Double>>();
            String[] Split_POLIZ = text.Split(' ');//режем текст по пробелам
            String str = "";
            foreach (String st in Split_POLIZ)
            {
                str = st.Replace(" ", "");//На всякий случай грязный хак
                if (str != "")
                    if (str != "!" && str != "∪" && str != "∩" && str != "con" && str != "dil" 
                        && str != "hemming" && str != "euclid" && str != "clearset" &&
                        str != "lineeuclid" && str != "linehemming")
                    {
                        foreach (var fuz in Mass)//бежим по массиву множеств и сверяем есть ли там такое
                            if (fuz.Name == str)
                            {
                                stack.Push(fuz); break;
                            }
                    }
                    else
                    {
                        switch (str)
                        {
                            case "!": stack.Push(!stack.Pop()); break;
                            case "∪": stack.Push(stack.Pop() + stack.Pop()); break;
                            case "∩": stack.Push(stack.Pop() / stack.Pop()); break;
                            case "con": stack.Push(stack.Pop().Con); break;
                            case "dil": stack.Push(stack.Pop().Dil); break;
                            case "clearset": stack.Push(stack.Pop().Get_Clear_Sets); break;
                            case "hemming":
                                if (stack.Count == 1)
                                    return Name + " = " + stack.Pop().Index_of_Hamming.ToString();
                                else
                                    return Name + " = " + "Неверно заданы операции";
                            case "euclid": if (stack.Count == 1)
                                    return Name + " = " + stack.Pop().Index_of_Euclid.ToString();
                                else
                                    return Name + " = " + "Неверно заданы операции";
                            case "lineeuclid": if (stack.Count == 1)
                                    return Name + " = " + stack.Pop().Index_of_Euclid_Line.ToString();
                                else
                                    return Name + " = " + "Неверно заданы операции";
                            case "linehemming": if (stack.Count == 1)
                                    return Name + " = " + stack.Pop().Index_of_Hamming_Line.ToString();
                                else
                                    return Name + " = " + "Неверно заданы операции";
                        }
                    }
            }
            if (stack.Count == 1)
                return Name + stack.Pop().ToString();
            else
                return Name + " = " + "Неверно заданы операции";
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void считатьМножестваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            read(Input_textBox.Text.Replace(" ", "").Replace("\n", "").Replace("\r", "").Replace("\t", "").Replace(".", ","));
        }

        private void построитьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckedListBox CheckedListBoxs = (contextMenuStrip1.SourceControl as CheckedListBox);
            if (CheckedListBoxs != null)
            {
                //Список множеств для отправки на постройку
                List<Fuzzy_sets<Double>> Selected_Items = new List<Fuzzy_sets<Double>>();
                foreach (var it in CheckedListBoxs.CheckedItems)//пробегаемся по отмеченным
                {
                    Fuzzy_sets<Double> _temp = (it as Fuzzy_sets<Double>);
                    if (_temp != null)//если преобразовалось то добавляем в список отправки
                    {
                        Selected_Items.Add(_temp);
                    }
                    else
                    {
                        String _temp1 = (it as String);
                        if (_temp1 != null)
                        {
                            try
                            {
                                Fuzzy_sets<Double> D = ConvertTo_Fuzzy_Sets(_temp1);
                                if (D != null)
                                {
                                    Selected_Items.Add(D);
                                }
                            }
                            catch
                            {
                                Error_Log_textBox.Text += "[Ошибка] Данное " + _temp1 + " вычисление нельзя построить!!!!. \r\n";//логи 
                            };
                        }
                    }
                }
                if (Selected_Items.Count != 0)//если количество больше 0
                    new Graphics1(Selected_Items).Show();//отправляем на построение
            }
        }

        /// <summary>
        /// Парсер строки в ПОЛИЗ
        /// </summary>
        /// <param name="input">Входная строка</param>
        /// <returns>Результат строка представляющая запись вида ПОЛИЗ</returns>
        public String MyRevers(string input)
        {
            String myoutputString = " ";
            Int32 sL = 0;
            Int32 sW = 0;

            for (Int32 i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    sL = sL + 1;
                }
                if (input[i] == ')')
                {
                    sW = sW + 1;
                }
            }
            if (sL != sW)
            {
                MessageBox.Show("Input error");
                return " ";

            }
            Regex rx = new Regex(@"\(|\)|\!|con|dil|euclid|hemming|clearset|lineeuclid|linehemming|∪|\∩|([A-Z][A-Z]*|[А-Я][А-Я]*)");
            MatchCollection mc = rx.Matches(input);

            Regex id = new Regex(@"[A-Z][A-Z]*|[А-Я][А-Я]*"); // идентификаторы
            Regex skobki = new Regex(@"\(|\)"); // скобки
            string[] operators = { "(", ")", "!", "con", "dil", "euclid", "hemming", "clearset", "lineeuclid", "linehemming", "∩", "∪" }; // операторы по приоритету

            Regex opers = new Regex(@"\(|\)|\!|con|dil|euclid|hemming|clearset|lineeuclid|linehemming|∪|\∩"); // операторы

            Stack stOper = new Stack();
            ArrayList expr = new ArrayList();
            foreach (Match m in mc)
            {
                Match m1;
                m1 = id.Match(m.Value);
                if (m1.Success) { expr.Add(m1.Value); continue; }
                m1 = skobki.Match(m.Value);
                if (m1.Success)
                {
                    if (m1.Value == "(") { stOper.Push(m1.Value); continue; }
                    string op = stOper.Pop().ToString();
                    while (op != "(")
                    {
                        expr.Add(op);
                        op = stOper.Pop().ToString();
                    }
                    continue;
                }
                m1 = opers.Match(m.Value);
                if (m1.Success)
                {
                    try
                    {
                        while (Array.IndexOf(operators, m1.Value) > Array.IndexOf(operators, stOper.Peek()))
                        {
                            if (stOper.Peek().ToString() == "(") break;
                            expr.Add(stOper.Pop().ToString());
                        }
                    }
                    catch
                    {

                    }
                    stOper.Push(m1.Value);
                }
            }
            while (stOper.Count != 0)
            {
                expr.Add(stOper.Pop().ToString());
            }

            foreach (string s in expr)
            {

                myoutputString += s + " ";
            }
            return myoutputString.Substring(1, myoutputString.Length - 2);
        }

        private void выполнитьОписанныеНижеДействияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            read(Input_textBox.Text);
            SplitCalculate(Instructions_textBox.Text);
        }

        private void toolStripButton_Click(object sender, EventArgs e)
        {
            switch ((sender as ToolStripButton).Text)
            {
                case "∪": Instructions_textBox.Paste("∪"); break;
                case "∩": Instructions_textBox.Paste("∩"); break;
                case "!": Instructions_textBox.Paste("!"); break;
                case "Con": Instructions_textBox.Paste("Con"); break;
                case "Dil": Instructions_textBox.Paste("Dil"); break;
                case "Euclid": Instructions_textBox.Paste("Euclid"); break;
                case "Hemming": Instructions_textBox.Paste("Hemming"); break;
                case "Clearset": Instructions_textBox.Paste("Clearset"); break;
                case "LineEuclid": Instructions_textBox.Paste("LineEuclid"); break;
                case "LineHemming": Instructions_textBox.Paste("LineHemming"); break;
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox1().Show();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "*.fuz|*.fuz";
            save.FilterIndex = 0;
            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter write = new StreamWriter(save.FileName))
                {
                    write.WriteLine(Input_textBox.Text);
                    write.WriteLine("/==============/");
                    write.WriteLine(Universal.Text);
                    write.WriteLine("/==============/");
                    write.Write(Instructions_textBox.Text);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "*.fuz|*.fuz";
            open.FilterIndex = 0;
            if (open.ShowDialog() == DialogResult.OK)//если нажали ок
            {
                Read_From_File(open.FileName);
            }
        }

        /// <summary>
        /// Функция загружающая инфу из файла
        /// </summary>
        /// <param name="FileName">Адрес файла</param>
        void Read_From_File(String FileName)
        {
            Input_textBox.Text = "";//очищаем поле с множествами
            Universal.Text = "";//очищаем с универсальным
            Instructions_textBox.Text = "";//очищаем с инструкциями
            using (StreamReader reade = new StreamReader(FileName))//открываем поток на чтение
            {
                Int32 i = 0;//обнуляем
                while (!reade.EndOfStream)//если не конец потока
                {
                    String s = reade.ReadLine();
                    if (s == "/==============/")
                    {
                        i++; s = "";
                    }
                    if (s != "")//если s не пустая
                    {
                        if (i == 0)
                            Input_textBox.Text += s + "\r\n";
                        if (i == 1)
                            Universal.Text += s + "\r\n";
                        if (i == 2)
                            Instructions_textBox.Text += s + "\r\n";
                    }
                }
            }
        }

        private void вБуферToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckedListBox CheckedListBoxs = (contextMenuStrip1.SourceControl as CheckedListBox);
            if (CheckedListBoxs != null)
            {
                String s = "";
                for (Int32 i = 0; i < CheckedListBoxs.Items.Count; i++)
                    s += CheckedListBoxs.Items[i].ToString() + "\r\n";
                Clipboard.SetText(s);
            }
        }

    }
}
