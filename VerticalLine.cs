﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; x <= yDown; y++) 
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }




        }

        
            }
        }




    }
}
