using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetBufferSize(100, 40);

            //отрисовка рамки
            HorizontalLine H1line = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine H2line = new HorizontalLine(0, 78, 24, '+');
            VerticalLine V1line = new VerticalLine(0, 24, 0, '+');
            VerticalLine V2line = new VerticalLine(0, 24, 78, '+');
            H1line.Drow();
            H2line.Drow();
            V1line.Drow();
            V2line.Drow();

            //отрисовка точек
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(4, 5, '#');
            p1.Draw();
            p2.Draw();

            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
