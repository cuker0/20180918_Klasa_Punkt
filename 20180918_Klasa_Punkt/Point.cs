using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180918_Klasa_Punkt
{
    class Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Point operator +(Point p1, Point p2)
        {
            Point result = new Point(p1.X + p2.X, p1.Y + p2.Y);
            return result;
        }

        public static Point operator -(Point p1, Point p2)
        {
            Point result = new Point(p1.X - p2.X, p1.Y - p2.Y);
            return result;
        }

        public static Point operator *(Point p1, int mnoznik)
            {
            Point result = new Point(p1.X * mnoznik, p1.Y * mnoznik);
            return result;
            }

        public void MoveLeft(double value)
        {

            X = X - value; 
        }

        public void MoveRight(double value)
        {

            X = X + value;
        }

        public void MoveUp(double value)
        {

            Y = Y + value;
        }
        public void MoveDown(double value)
        {

            Y = Y - value;
        }


        public void show()
        {
            Console.WriteLine("Wspolrzedne X:{0} Y:{1}", X, Y);
            Console.ReadKey();
        }
        
      
    }
}
