using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment_5
{
    class Program
    {
        public void funA(double l, double w)
        {
            double circumference = 2 * (l + w);
            Console.WriteLine("the circumference is {0}", circumference);
        }
        public static double funB(double l, double w)
        {
            double circumference = 2 * (l + w);
            return circumference;
        }
        public void funC(double l, double w)
        {
            double area = l * w;
            Console.WriteLine("the area is {0}", area);
        }
        void Main(string[] args)
        {
            double length = 6;
            double width = 4;
            double circum = 0;
            funA(length, width);
            funC(length, width);
            circum = funB(length, width);
            Console.WriteLine(circum);

            Console.ReadLine();
        }
    }
}
