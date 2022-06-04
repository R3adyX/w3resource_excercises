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
            var number4 = 0;
            var number5 = 0;


            //Ex 1 Write a C# Sharp program to print Hello and your name in a separate line.
            Console.WriteLine("Hello: Stephen Cutts");
            Console.WriteLine();


            //Ex 2 Write a C# Sharp program to print the sum of two numbers.
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

            //Ex 7 Write a C# Sharp program to print on screen the output of adding,
            //subtracting, multiplying and dividing of two numbers which will be entered by the user
            Console.Write("1st number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2nd number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            var add = number1 + number2;
            var subtract = number1 - number2;
            var multiply = number1 * number2;
            var divide = number1 / number2;
            var mod = number1 % number2;

            Console.WriteLine($"{number1} + {number2} = {add}");
            Console.WriteLine($"{number1} - {number2} = {subtract}");
            Console.WriteLine($"{number1} * {number2} = {multiply}");
            Console.WriteLine($"{number1} / {number2} = {divide}");
            Console.WriteLine($"{number1} % {number2} = {mod}");

            Console.WriteLine();


            //Ex 8 Write a C# Sharp program that takes a number as input and print its multiplication table
            Console.Write("Enter a Number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < 3; i++)
            {
                var ex8Result = number1 * i;
                Console.WriteLine($"{number1} * {i} = {ex8Result}");
            }

            //Ex 9 Write a C# Sharp program that takes four numbers as input to calculate and print the average.
            var inputTotal = 0;
            for (var i = 1; i < 5; i++)
            {
                Console.Write("Enter a number: ");
                inputTotal++;
                switch(i)
                {
                    case 1: number1 = Convert.ToInt32(Console.ReadLine()); break;
                    case 2: number2 = Convert.ToInt32(Console.ReadLine()); break;
                    case 3: number3 = Convert.ToInt32(Console.ReadLine()); break;
                    case 4: number4 = Convert.ToInt32(Console.ReadLine()); break;
                    default: break;
                }
            }

            var average = (number1 + number2 + number3 + number4) / inputTotal;
            Console.WriteLine($"The average of {number1}, {number2}, {number3}, {number4} is : {average} Number of user Entries: {inputTotal}");

            
            //Ex 10 Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.
            var x = 0;
            var y = 0;
            var z = 0;
            for (var i = 1; i < 5; i++)
            {
                Console.Write("Enter a number: ");
                switch (i)
                {
                    case 1: x = Convert.ToInt32(Console.ReadLine()); break;
                    case 2: y = Convert.ToInt32(Console.ReadLine()); break;
                    case 3: z = Convert.ToInt32(Console.ReadLine()); break;
                    default: break;
                }
            }
            var ex10Results1 = (x + y) * z;
            var ex10Results2 = x * y + y * z;
            Console.WriteLine($"Result of specified numbers {x}, {y}, {z}, ({x}+{y}) * z is: {ex10Results1} and {x} * {y} + {y} * {z} is: {ex10Results2}");
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
