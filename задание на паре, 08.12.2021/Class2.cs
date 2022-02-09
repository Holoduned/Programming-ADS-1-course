using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.задание_класс
{
    public class Rectangle
    {
        public int a, b;

        public Rectangle(int a, int b)
        {
            this.a = a; this.b = b;
        }

        public int RectangleSquare(int a, int b)
        {
            return a * b;
        }

        public int RectanglePerimetr(int a, int b)
        {
            return (a + b) * 2;
        }
    }

    public class Vertor2D
    {
        int x, y;

        public Vertor2D(int x, int y)
        {
            this.x = x; this.y = y;
        }
    }


}
