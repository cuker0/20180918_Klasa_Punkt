using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180918_Klasa_Punkt
{
    class Point3d : Point
    {
        public double Z { get; private set; }

        public Point3d(double x, double y, double z) : base(x, y) // base odwoluje sie do konstruktora w point
        {
            Z = z;
        }
        public void SetName1(string name)
        {
            //SetName(name);  // w przypadku gdy _name jest private
            _name = name;       // w przypadku gdy _name jest protected. dziedziczenie klasowe
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Z: {Z} ");
        }

        //public override void Show() // nowa konstrukcja tylko dla Point3d
        //{
        //    Console.WriteLine($"Wspolrzedne X:{X} Y:{Y} Z:{Z}");
        //    Console.ReadKey();
        //}


    }
}
