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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine H1line = new HorizontalLine(20, 40, 20, '+');
            H1line.Draw();

            HorizontalLine H2line = new HorizontalLine(20, 40, 40, '+');
            H2line.Draw();

            VerticalLine V1line = new VerticalLine(20, 40, 20, '+');
            V1line.Draw();

            VerticalLine V2line = new VerticalLine(20, 40, 40, '+');
            V2line.Draw();

            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
