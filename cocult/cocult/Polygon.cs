using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    class Polygon : Figure
    {
       /// <summary>
       /// поле для хранения колличества вершин
       /// </summary>
        public int NumVertex { get; set; }
        /// <summary>
        /// лист для хранения всех вершин
        /// </summary>
        private List<Point> _polygonVertex;

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="n">колличество вершин</param>
        public Polygon(int n)
        {
            NumVertex = n;

            _polygonVertex = new List<Point>();
        }

        /// <summary>
        /// метод для ввода вершин
        /// </summary>
        public void Input()
        {

            
            for (int i = 0; i < NumVertex; i++)
            {
                Console.WriteLine($"Ввод данных вершины ");
                Console.WriteLine($"Ввод X");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Ввод Y");
                int y = Convert.ToInt32(Console.ReadLine());

                _polygonVertex.Add(new Point(x,y));
            }

            _polygonVertex.Add(_polygonVertex[0]);
        }

        /// <summary>
        /// метод вычисления периметра многоугольника
        /// </summary>
        /// <returns>возращает периметр многоугольника</returns>
        public override double P()
        {
            double p = 0;

            for(int i = 0; i < _polygonVertex.Count-1; i++)
            {
                p += Math.Pow(_polygonVertex[i+1].Y - _polygonVertex[i].Y,2) + Math.Pow(_polygonVertex[i + 1].X - _polygonVertex[i].X, 2);   
            }

            return Math.Sqrt(p);
        }

        /// <summary>
        /// метод вычисления площадь многоугольника
        /// </summary>
        /// <returns>возращает площадь многоугольника</returns>
        public override double S()
        {
            double num1 = 0;
            double num2 = 0;

            for (int i = 0; i < _polygonVertex.Count - 1; i++)
            {
                num1 += _polygonVertex[i].X * _polygonVertex[i + 1].Y;
                num2 += _polygonVertex[i].Y * _polygonVertex[i + 1].X;
            }

            return Math.Abs(num1 - num2) / 2;
        }

        /// <summary>
        /// метод для вывода информации о многоугольнике
        /// </summary>
        public override void OutputInf()
        {
            Console.WriteLine($"Многоугольник ");
            for (int i = 0; i < _polygonVertex.Count; i++)
            {
                Console.WriteLine($"Вершина {i}: ({_polygonVertex[i].X};{_polygonVertex[i].Y})");
            }
        }
    }
}
