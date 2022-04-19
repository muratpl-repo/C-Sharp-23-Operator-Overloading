using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64OperatorOverloading // Iki instance'i (Ornegi) birbiriyle toplayabilmek icin kulanıldı bu ornekte...
{
    class Program
    {   
        class Vektor
        {
            public int X { get; set; } //Properties..
            public int Y { get; set; } //Properties..

            public Vektor(int x, int y) //Constructor metot..
            {
                X = x;
                Y = y;
            }
            public static Vektor operator+(Vektor a, Vektor b) // Bu da bir nevi Constructormis..
            {
                int yeniVektorX = a.X + b.X;
                int yeniVektorY = a.Y + b.Y;
                Vektor c = new Vektor(yeniVektorX, yeniVektorY);
                return c;
            }
        }
        static void Main(string[] args)
        {
            Vektor v1 = new Vektor(1, 2);
            Vektor v2 = new Vektor(2, 5); // Instance-Ornek -- Instantiation=Ornekleme
            Vektor v3 = v1 + v2;
            Console.WriteLine(v3.X + " " + v3.Y);
        }
    }
}
