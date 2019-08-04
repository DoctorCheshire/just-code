using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# program that accept the values of two variables (the type int and named as v1 and v2 ) from the user. 
            The program will perform the following operations:
            v1++;
            ++v1;
            v1=v2++;
            v1=++v2;
            v1 +=v2;
            v1 /= v2;
            For each operation above, if the result is greater than or equal to 100, output the result.
            Otherwise, only output a message telling the user that the result is less than 100.*/

            Console.WriteLine("enter two numbers");
            int v1 = Convert.ToInt32(Console.ReadLine());
            int v2 = Convert.ToInt32(Console.ReadLine());
            int[] results = new int[6];

            results[0] = v1++;
            results[1] = ++v1;
            results[2] = v1 = v2++;
            results[3] = v1 = ++v2;
            results[4] = v1 += v2;
            results[5] = v1 /= v1;

            for (int i = 0; i < results.Length; i++)
            {
                if (results[i] >= 100)
                {
                    Console.WriteLine("{0}", results[i]);
                }
                else
                {
                    Console.WriteLine("the result is less than 100");
                }
            }
            /*Write a C# program that firstly repeats the following operations for five times: (20 points)
             * ask the user to input the radius of a circle as an integer
             * If the user's input is less than zero, remind the user.
             * otherwise, calculate and displays the circle’s diameter, circumference and area.
        Then, output a message to inform the user that he/she has input for five times.
        When working on this question, you should use the double value 3.14159 for π, and the following formulas:
            diameter = 2r
            circumference = 2πr
            area = πr2 */

            const double PI= 3.14159;
            double[] circle = new double[3];
            Console.WriteLine("input the radius of a circle as an integer");
            int r = Convert.ToInt32(Console.ReadLine());
            if (r < 0)
            {
                Console.WriteLine("input the radius of a circle as an integer");
                r = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Convert.ToDouble(r);
                circle[0] = 2 * r;
                circle[1] = 2 * PI * r;
                circle[2] = PI * r * 2;
                Console.WriteLine("the diameter is {0}", circle[0]);
                Console.WriteLine("the circumference is {0}", circle[1]);
                Console.WriteLine("the area is {0}", circle[2]);
            }
            /* Write a C# program that calculates the squares and cubes of the numbers from 0 to 10 and 
             * displays the resulting values in table format, as shown below. 
             * All calculations should be done in terms of a variable x. 
             * (2) Use a loop] (20 points) */

            int[] squares = new int[11];
            int[] cubes = new int[11];

            for (int i=0; i<squares.Length; i++)
            {
                Console.Write("the square of {0} is {1}", i, i * i);
                Console.WriteLine("        the cube of {0} is {1}", i, i * i * i);
            }

            /*Repeat to calculate Body Mass Index five times*/
            
            for (int i=0; i<5; i++)
            {
                Console.WriteLine("enter your weight in pounds: ");
                double weight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter your height in inches: ");
                double height = Convert.ToDouble(Console.ReadLine());
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

            Console.ReadLine();
        }
    }
}
