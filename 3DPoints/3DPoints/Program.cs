using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DPoints
{  
        public struct Point
        {
            private int x, y, z;
            public Point(int xPos, int yPos, int zPos)
            {
                x = xPos;
                y = yPos;
                z = zPos;
            }
            public static Point operator +(Point p1, Point p2)
            {
                return new Point(p1.x + p2.x, p1.y + p2.y, p1.z + p2.z);
            }
            public override string ToString()
            {
                return string.Format("{0}, {1}, {2}",this.x, this.y, this.z);
            }
        }
    class Program
    {
        static void Main()
        {
            Point a = new Point(2, 2, 2);
            Point b = new Point(5, 6, 7);
            Point c = a + b;
            Console.WriteLine("c = {0}", c);

            // Delay
            Console.ReadKey();
        }
    }
}
