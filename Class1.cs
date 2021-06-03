using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using multiplication;
namespace area
{
    public class Class2
    {
        public void Square(int side)
        {
            Class1 obj = new Class1();
            Console.WriteLine("area:"+(obj.Mul(side, side)));
        }
        public void Circle(int radius)
        {
            Class1 obj = new Class1();
            Console.WriteLine("area:" +(obj.Mul(radius, radius) *3.14));
        }
        public void Triangle(int l,int b)
        {
            Class1 obj = new Class1();
            Console.WriteLine("area:" + (obj.Mul(l, b) /2));
        }
    }
}
