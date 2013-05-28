using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Fuzzy_sets;

namespace fuzzy_sets_GUI
{
    public partial class Graphics1 : Form
    {
        /// <summary>
        /// Список цветов
        /// </summary>
        List<Color> Color_Array = new List<Color>();
        /// <summary>
        /// Полученные множества для построения графика
        /// </summary>
        List<Fuzzy_sets<Double>> Selecteds;
        Double MAX = 0;//максимум для постройки графиков
        public Graphics1(List<Fuzzy_sets<Double>> Selecteds)
        {
            this.Selecteds = Selecteds;
            InitializeComponent();

            ColorDialog ccol = new ColorDialog();

            List<Label> Label_Array = new List<Label>();

            MAX = Math.Abs(Selecteds[0][0].Element);//максимум для постройки графика
            foreach (var e in Selecteds)
            {
                if (ccol.ShowDialog() == DialogResult.OK)
                    Color_Array.Add(ccol.Color);
                for (int i = 0; i < e.Count; i++)
                    if (MAX < Math.Abs(e[i].Element)) MAX = Math.Abs(e[i].Element);

                Label _Temp = new Label()
                {
                    AutoSize = true,
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)))
                };
                Label_Array.Add(_Temp);
            }
            for (Int32 i = 0; i < Selecteds.Count; i++)
            {
                Label_Array[i].Text = Selecteds[i].Name;
                Label_Array[i].ForeColor = Color_Array[i];
                Label_Array[i].Location = new Point(3, (i * 15) + 25);
                this.Controls.Add(Label_Array[i]);
            }
            Ris();
        }

        Graphics gr;

        void inint_gr()
        {
            Int32 _Height = pictureBox1.Height, _Width = pictureBox1.Width;//размеры холста
            if (_Height > 0 && _Width > 0)
            {
                Image im = new Bitmap(_Width, _Height);
                //Пикчер боксу присваиваю изображение на котором буду рисовать
                pictureBox1.Image = im;
                //Создаю объект график
                gr = Graphics.FromImage(pictureBox1.Image);

                //Задаю новую систему координат с серединой экрана
                gr.TranslateTransform(_Width / 2, _Height);
                //Располагаю оси с право на лево
                //Снизу  в верх.
                gr.ScaleTransform(1, -1);

                //Создаю карандаш/перо
                Pen p = new Pen(Brushes.Black);

                #region ставлю надсечки для осей
                #region ставлю надсечки для OX
                for (int i = 0; i < _Width / 2; i += 25)
                {
                    gr.DrawLine(Pens.LightGray, i, 20, i, _Height + 30);
                    gr.DrawLine(Pens.LightGray, -i, 20, -i, _Height + 30);
                    gr.DrawLine(p, i, 20, i, 30);
                    gr.DrawLine(p, -i, 20, -i, 30);
                }
                #endregion
                #region ставлю надсечки для OY
                for (int i = 0; i < _Height; i += 25)
                {
                    gr.DrawLine(Pens.LightGray, -5 - _Width / 2, i, 5 + _Width / 2, i);
                    gr.DrawLine(p, -5, i, 5, i);
                }
                #endregion
                #endregion
                //Создаю массив точек
                Point[] _Point = new Point[4];
                #region ТОчки для осей
                #region ОХ
                //Первая точка OX
                _Point[0] = new Point
                {
                    X = (-_Width / 2),
                    Y = 25
                };
                //Вторя точка OX
                _Point[1] = new Point
                {
                    X = (_Width / 2),
                    Y = 25
                };
                #endregion
                #region ОY
                //Первая точка OY
                _Point[2] = new Point
                {
                    X = 0,
                    Y = -_Height
                };
                //Вторя точка OY
                _Point[3] = new Point
                {
                    X = 0,
                    Y = _Height
                };
                #endregion
                #endregion
                //рисую оси
                gr.DrawLine(p, _Point[0], _Point[1]);
                gr.DrawLine(p, _Point[2], _Point[3]);
                #region Ставлю надписи на надсечки
                //Зеркалю
                gr.ScaleTransform(1, -1);
                //OX
                for (int i = 0; i < _Width / 2; i += 25)
                {
                    gr.DrawString(Math.Round(i / ((_Width / 2d) / MAX), 2).ToString(), DefaultFont, Brushes.Black, (float)i, (float)-20);
                    gr.DrawString(Math.Round(-i / ((_Width / 2d) / MAX), 2).ToString(), DefaultFont, Brushes.Black, (float)-i, (float)-20);
                }
                //OY
                for (int i = 0; i < _Height; i += 25)
                {
                    gr.DrawString(Math.Round(i / (Double)(_Height - 25), 2).ToString(), DefaultFont, Brushes.Black, (float)4, (float)-i - 25);
                }
                //еще раз зеркалю
                gr.ScaleTransform(1, -1);
                #endregion
            }
        }

        void plot(Fuzzy_sets<Double> e, Brush _Brush)
        {
            Int32 _Height = pictureBox1.Height, _Width = pictureBox1.Width;//размеры холста

            Point[] _p = new Point[e.Count];//линии
            //сортировка элементов по оси х
            Fuzzy_sets<Double> _T = e.Sort_from_Element;
            for (int i = 0; i < e.Count; i++)
            {
                _p[i].X = (int)((int)(e[i].Element * ((_Width / 2d) / MAX)));//добавляем точку x для контура
                _p[i].Y = (int)((int)((e[i].Accessory_Function) * (_Height - 25) + 25));//точку y для контура
                gr.FillEllipse(_Brush, (int)(e[i].Element * ((_Width / 2d) / MAX)) - 3, (int)((e[i].Accessory_Function) * (_Height - 25) + 22), 6, 6);
            }
            if (checkBox1.Checked)
                gr.DrawLines(new Pen(_Brush), _p);
        }

        private void Graphics_Load(object sender, EventArgs e)
        {

        }

        void Ris()
        {
            inint_gr();
            for (Int32 i = 0; i < Selecteds.Count; i++)
            {
                plot(Selecteds[i], new SolidBrush(Color_Array[i]));
            }
        }

        private void Graphics1_SizeChanged(object sender, EventArgs e)
        {
            Ris();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Ris();
        }
    }
}
