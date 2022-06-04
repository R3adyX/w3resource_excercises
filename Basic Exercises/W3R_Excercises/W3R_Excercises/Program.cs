using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3R_Excercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number1 = 0;
            var number2 = 0;
            var number3 = 0;
            
            //Ex 1 Write a C# Sharp program to print Hello and your name in a separate line.
            Console.WriteLine("Hello: Stephen Cutts");
            Console.WriteLine();


            //Ex 2 Write a C# Sharp program to print the result of dividing two numbers.
            var n1 = 10;
            var n2 = 2;

            var sum = n1 + n2;
            Console.WriteLine(sum);
            Console.WriteLine();


            //Ex 3 Write a C# Sharp program to print the result of dividing two numbers. 
            var result = n1 / n2;
            Console.WriteLine(result);
            Console.WriteLine();


            //Ex 4 Write a C# Sharp program to print the result of the specified operations
            var result1 = -1 + (4 * 6);
            var result2 = (35 + 5) % 7;
            var result3 = 14 + -4 * 6 / 11;
            var result4 = 2 + (15 / 6) * 1 - (7 % 2);

            Console.WriteLine($"Result 1: {result1} Result 2: {result2} Result 3: {result3} Result 5: {result4}");
            Console.WriteLine();
            
            
            //Ex 5  Write a C# Sharp program to swap two numbers. 

            var firstNum = 5;
            
            var buffer = firstNum;
            var secondNum = 6;
            var buffer2 = secondNum;
            
            Console.WriteLine($"First Number b4: {firstNum} Second Number b4: {secondNum}");
            
            firstNum = buffer2;
            secondNum = buffer;

            Console.WriteLine($"First Number After: {firstNum} Second Number After: {secondNum}");
            Console.WriteLine();

            //Ex 6 Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
            Console.WriteLine("Enter 1st number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter 3rd number: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            var ex6Result = (number1 * number2) * number3;

            Console.WriteLine($"{number1} x {number2} x {number3} = {ex6Result}");

            number1 = 0;
            number2 = 0;
            number3 = 0;

            
            //Ex 7

            //Ex 8

            //Ex 9

            //Ex 10

            //Ex 11

            //Ex 12

            //Ex 13

            //Ex 14

            //Ex 15

            //Ex 16

            //Ex 17

            //Ex 18

            //Ex 19

            //Ex 20

            //Ex 
        }
    }
}
