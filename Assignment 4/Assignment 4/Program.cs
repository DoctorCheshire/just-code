using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Firstly, write a C# function that has two parameters(named pv1 and pv2) and has no return statement. 
             * That is, it will not return any value to the caller after it is called. The data type of each parameter is 
             * an integer. This function will have the following operations:
             * pv1++;
             * pv1=pv2++;
             * pv1 *=pv2;
             * When each operation above is done, output its value (using Console.WriteLine()). Then, write a main function that 
             * defines two variables( named mv1 and mv2). The main function calls the function above and passes mv1 and mv2 to 
             * the function.*/

            int mv1 = 6;
            int mv2 = 7;
            first(mv1, mv2);
            double mradius = 4;
            double marea = second(mradius);
            Console.WriteLine("the area is {0}", marea);
            third();
            double mweight = 145, mheight = 58;
            forth(mweight, mheight);

            Console.ReadLine();
        }
        public static void first(int pv1, int pv2)
        {
            Console.WriteLine("pv1++ is {0}", pv1++);
            Console.WriteLine("pv1=pv2++ is {0}", pv1 = pv2++);
            Console.WriteLine("pv1*=pv2 is {0}", pv1 *= pv2);

        }
        /*Write a C# function that has one parameter (named radius) and a return statement that returns the area of a circle. 
         * That is, this function will perform the following operations:
         * Define a local variable named localRadius and a local variable named area;
         * Assign the value of radius to the variable localRadius;
         * Calculate the area of the circle, that is, area = 3.1415926*r2;
         * Return the area in its return statement.
         * Then, write a main function that defines two variables( named mradius and marea). The main function calls the 
         * function above and pass the value of mradius to the function. After the function is done, the returned value 
         * from the function is assigned to marea. The main prints the value of marea*/

        public static double second(double radius)
        {
            double localRadius = radius;
            double area = 3.1415926 * radius * radius;
            return area;
        }
        /*) Write a C# function that calculates the squares and cubes of the numbers from 0 to 10 and displays the resulting 
         * values in table format, as shown below. All calculations should be done in terms of a variable x defined in the 
         * function. [Note: this function does not have any parameter, and does not return any value. That is, when it is called,
         * it will perform the operations above and then stop. Then, write a main function that will call this function.*/
         public static void third()
        {
            int[] squares = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] cubes = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("number       square      cube");

            for (int i = 0; i < squares.Length; i++)
            {
                Console.WriteLine("{0}            {1}            {2}", i, i * i, i * i * i);
            }             
        }
        /* Write a C# function that has two parameters (named weight and height) and has no return statement. When it is 
 * called, it calculates Body Mass Index (BMI). The formulas for calculating the Body Mass Index (BMI) are 
 * If either of them is zero or negative, output an error message and BMI will not be calculated. Otherwise, the 
 * function calculates and displays the user’s body mass index. Then, write a main function that defines two 
 * variables( named mweight and mheight). The main function calls the function above and pass the values of 
 * mweight and mheight to the function.*/

        public static void forth(double weight, double height)
        {
            if(weight <= 0)
            {
                Console.WriteLine("error please enter a positive number");
            }
            if (height <= 0)
            {
                Console.WriteLine("error please enter a positive number");
            }
            double BMI = (weight * 703) / (height * height);

            Console.WriteLine("your BMI is {0}", BMI);
            Console.Write("Department of Health and");
            Console.WriteLine("Human Services / National Institutes of Health states the following:");
            Console.WriteLine("BMI VALUES");
            Console.WriteLine("Underweight: less than 18.5");
            Console.WriteLine("Normal: between 18.6 and 24.9");
            Console.WriteLine("Overweight: between 25 and 29.9");
            Console.WriteLine("Obese: 30 or greater");
        }
    }
}
