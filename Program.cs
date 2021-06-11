using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(150, 50);
            Point p = new Point(4, 5, '*');
            p.Draw();

            // Отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine(1, 78, 1, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();



           

            



        }
        
    }
}
