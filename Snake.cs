using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class Snake : Figure
    { 
        Direction direction;
    
        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }

        }
            
    }
}
