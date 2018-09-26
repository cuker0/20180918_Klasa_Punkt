using System;

namespace _20180918_Klasa_Punkt
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pt1 = new Point(1,5);
            Point pt2 = new Point(5, -11);
            Point pt3 = pt1 + pt2;
            Point pt4 = pt1 - pt2;
            Point pt5 = pt4 * 5;

            //pt2.Show();
            //for (int i = 0; i < 5; i++)
            //{
            //    Point pt = new Point(i,i);               
            //}

            //Console.WriteLine(Point.Licznik);
                        

            Point3d XYZ = new Point3d(1, 2, 3);

            Point punkt = XYZ;
            punkt.Show();
            Console.WriteLine(punkt);
            Console.ReadKey();
         
        }
    }
}
