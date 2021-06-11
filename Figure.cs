using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class Figure
    {
        List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
