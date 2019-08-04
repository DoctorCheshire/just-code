using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
    /*Write a C# program that displays a box, an oval, 
    * an arrow and a diamond using asterisks (*), as follows*/

            Console.WriteLine("*********     ***       *        *");
            Console.WriteLine("*       *   *     *    ***      * *");
            Console.WriteLine("*       *   *     *   *****    *   *");
            Console.WriteLine("*       *   *     *     *     *     *");
            Console.WriteLine("*       *   *     *     *      *   *");
            Console.WriteLine("*       *   *     *     *       * *");
            Console.WriteLine("*********     ***       *        *");

    /*Write a C# program that accept the values of two
    variables (the type double and named as v1 and v2 ) from the user. The program will perform
    the following operations and output the result of each operation: v1++; ++v1; v1=v2++; v1=++v2; v1 +=v2; v1 /= v2*/

            Console.WriteLine("enter a number: ");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter another number: ");
            double v2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("v1++ = {0}", v1++);
            Console.WriteLine("++v1 = {0}", ++v1);
            Console.WriteLine("v1=v2++ = {0}", v1 = v2++);
            Console.WriteLine("v1=++v2 = {0}", v1 = ++v2);
            Console.WriteLine("v1+=v2 = {0}", v1 += v2);
            Console.WriteLine("v1/=v2 = {0}", v1 /= v2);

    /* Write a C# program that inputs from the user the radius of a circle as
    an integer and displays the circle’s diameter, circumference and area using the floating-point
    value 3.14159 for π or  use the predefined constant Math.PI for the value of π
    diameter = 2r
    circumference = 2πr
    area = πr2
    Don’t store each calculation’s result in a variable. Rather, specify each calculation as the value
    to be output in a Console.WriteLine statement. The values produced by the circumference and
    area calculations are floating-point numbers.*/

            double radius = 0;
    //const Math.PI;            don't need to declare PI, but make the variable a double

            Console.WriteLine("enter the radius of a circle: ");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("diameter = {0}", 2 * radius);
            Console.WriteLine("circumference = {0}", 2 * Math.PI * radius);
            Console.WriteLine("area = {0}", Math.PI * radius * 2);

    /*Using only the programming techniques you learned in this
    chapter, write a C# program that calculates the squares and cubes of the numbers from 0 to
    10 and displays the resulting values in table format, as shown below. All calculations should be
    done in terms of a variable x. [Note: This program does not require any input from the user.]*/

    //use a loop
            int num = 0;
            Console.Write("the square of {0} is {1}", num, num * num);                      //loop it later
            Console.WriteLine("        the cube of {0} is {1}", num, num * num * num);      //loop it later
            num++;
            Console.Write("the square of {0} is {1}", num, num * num);
            Console.WriteLine("        the cube of {0} is {1}", num, num * num * num);
            num++;
            Console.Write("the square of {0} is {1}", num, num * num);
            Console.WriteLine("        the cube of {0} is {1}", num, num * num * num);
            num++;
            Console.Write("the square of {0} is {1}", num, num * num);
            Console.WriteLine("        the cube of {0} is {1}", num, num * num * num);
            num++;
            Console.Write("the square of {0} is {1}", num, num * num);
            Console.WriteLine("       the cube of {0} is {1}", num, num * num * num);
            num++;
            Console.Write("the square of {0} is {1}", num, num * num);
            Console.WriteLine("       the cube of {0} is {1}", num, num * num * num);
            num++;
            Console.Write("the square of {0} is {1}", num, num * num);
            Console.WriteLine("       the cube of {0} is {1}", num, num * num * num);
            num++;
            Console.Write("the square of {0} is {1}", num, num * num);
            Console.WriteLine("       the cube of {0} is {1}", num, num * num * num);
            num++;
            Console.Write("the square of {0} is {1}", num, num * num);
            Console.WriteLine("       the cube of {0} is {1}", num, num * num * num);
            num++;
            Console.Write("the square of {0} is {1}", num, num * num);
            Console.WriteLine("       the cube of {0} is {1}", num, num * num * num);
            num++;
            Console.Write("the square of {0} is {1}", num, num * num);
            Console.WriteLine("     the cube of {0} is {1}", num, num * num * num);

            /*Calculate Body Mass Index
             BMI = wieghtInPounds * 703 / heightInInches * heightInInches
             Create a BMI calculator program that reads the user’s weight in pounds and height in inches
            and then calculates and displays the user’s body mass index. Other than the value of BMI, the
            program should also display the following information from the Department of Health and
            Human Services/National Institutes of Health so the user can evaluate his/her BMI*/

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


            Console.ReadLine();
        }
    }
}
