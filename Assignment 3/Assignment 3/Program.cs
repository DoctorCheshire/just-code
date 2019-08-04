using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*(1) define an integer array have 11 elements. The values of these elements are from 0 to 10.
              (2) apply a loop to create the table: number square cube*/

            int[] squares = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] cubes = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("number       square      cube");

            for (int i = 0; i < squares.Length; i++)
            {
                Console.WriteLine("{0}            {1}            {2}", i, i * i, i * i * i);
            }

            bool same = false;
            same = SameNotSame();
            if (same == false)
            {
                Console.WriteLine("the array has an element of the same value");
            }
            else
            {
                Console.WriteLine("the array has no such value");
            }


            /*(1) ask the user to input a string
                (2) find out the length of the string
                (3) convert the string into lowercase
                (4) convert the string into uppercase
                (5) Display the string by applying PadLeft */

            Console.WriteLine("input a string");
            string str2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("You typed {0} characters", str2.Length);
            str2.ToLower();
            str2.ToUpper();
            Console.WriteLine(str2);

            Console.ReadLine();
        }
        /*(1) define an integer array have 20 elements. The values of these elements are from 0 to 19
(2) ask the user to input an integer.
(3) compare the integer entered by the user to each element in the array. If the user input is
equal to an element of the array, tell the user that the array has an element having the same
value. Otherwise, tell the user that the array has no such a value. */
        public static bool SameNotSame()
        {

            int[] comparison = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            Console.WriteLine("input an integer");
            int num = Convert.ToInt32(Console.ReadLine());
            bool same = false;

            for (int i = 0; i < comparison.Length; i++)
            {
                if (comparison[i] == num)
                {
                    same = true;
                }
                else
                {
                    same = false;
                }
            }
            return same;    //needs to be outside of the for loop
        }
    }
}
