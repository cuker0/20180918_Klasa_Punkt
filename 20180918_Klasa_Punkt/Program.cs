using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            pt1.show();
            pt2.show();
            pt3.show();
            pt4.show();
            pt5.show();

            pt1.MoveDown(5.5);
            pt1.show();
            pt1.MoveUp(43.2);
            pt1.show();
            pt1.MoveLeft(-99.94);
            pt1.show();
            pt1.MoveRight(44.32);
            pt1.show();
            
        }
    }
}
