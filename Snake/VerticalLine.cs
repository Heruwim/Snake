using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class VerticalLine
    {
        List<Point> hList;

        public VerticalLine(int x, int yDown, int yUp,  char sym)
        {
            hList = new List<Point>();
            for (int y = yDown; y <= yUp; y++)
            {
                Point p = new Point(x, y, sym);
                hList.Add(p);
            }

        }

        public void Drow()
        {
            foreach (Point p in hList)
            {
                p.Draw();
            }
        }
    }
}
