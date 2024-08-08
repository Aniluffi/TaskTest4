using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    class Point
    {
       

        /// <summary>
        /// поле для хранения x вершины
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// поле для хранения y вершины
        /// </summary>
        public int Y { get; set; } 
        
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
