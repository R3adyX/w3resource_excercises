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
            

            //Ex 11 Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20".
         
            Console.Write("Enter age: ");
            var age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"You look older than {age}.");
            


            //Ex 12 Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}.
            Console.WriteLine("Enter a Number:");
            var exI12Input = Convert.ToInt32(Console.ReadLine());
            Console.Write(exI12Input);
            Console.Write(" ");
            Console.Write(exI12Input);
            Console.Write(" ");
            Console.Write(exI12Input);
            Console.Write(" ");
            Console.Write(exI12Input);
            Console.Write("");
            Console.WriteLine();

            Console.Write(exI12Input);
            Console.Write(exI12Input);
            Console.Write(exI12Input);
            Console.Write(exI12Input);
            Console.WriteLine();

            Console.WriteLine("{0} {0} {0} {0}", exI12Input);
            Console.WriteLine("{0}{0}{0}{0}", exI12Input);
           

            //Ex 13 Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.
            Console.Write("Enter a number: ");
            var ex13Num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", ex13Num);
            Console.WriteLine("{0} {0}", ex13Num);
            Console.WriteLine("{0} {0}", ex13Num);
            Console.WriteLine("{0} {0}", ex13Num);
            Console.WriteLine("{0}{0}{0}", ex13Num);
            

            //Ex 14 Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
            Console.Write("Enter the amount of celsius: ");
            var celsius = Convert.ToInt32(Console.ReadLine());
            var convertToKelvin = celsius + 273; //273.15
            var convertToFahrenheit = celsius * 1.800 + 32;
            Console.WriteLine($"Converted to Kelvin: {convertToKelvin}");
            Console.WriteLine($"Converted to Kelvin: {convertToFahrenheit}");


            //Ex 15  Write a C# program remove specified a character from a non-empty string using index of a character.
            var word = "Hello".ToLower();
            char[] myStr = word.ToCharArray();
            
            Console.WriteLine(word);

            Console.Write("Choose a letter to take out: ");
            var ex15userinput = Convert.ToChar(Console.ReadLine().ToLower());

            for (var i = 0; i < myStr.Length; i++)
            {
                if (myStr[i] == ex15userinput)
                {
                    continue;
                }
                Console.Write(myStr[i]);
               
            }
            Console.WriteLine();
          

            //Ex 16 Write a C# program to create a new string from a given string where the first and last characters will change their positions.
            Console.Write("Enter a word: ");
            var oldString = Console.ReadLine().ToLower();
            Console.WriteLine(FrontBack(oldString));
            

            //Ex 17 Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.
            Console.Write("Enter a word: ");
            var ex17oldString = Console.ReadLine().ToLower();
            Console.WriteLine(FrontAndBack(ex17oldString));

            //Ex 18 Write a C# program to check two given integers and return true if one is negative and one is positive.
            var ex18Num1 = -15;
            var ex18Num2 = 25;

            if ((ex18Num1 < 0) && (ex18Num2 >= 0))
            {
                Console.WriteLine($"First integer input : {ex18Num1}");
                Console.WriteLine($"Second integer input : {ex18Num2}");
                Console.WriteLine($"Is 1 Number Positive and 1 Negative: True");
            }
            else
            {
                Console.WriteLine($"Is 1 Number Positive and 1 Negative: False");
            }
            

            //Ex 19 Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.
            var ex19Num1 = 5;
            var ex19Num2 = 5;
            Console.WriteLine(ThreeTimes(ex19Num1, ex19Num2));


            //Ex 20 Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than second number.
            var ex20Num1 = 10;
            var ex20Num2 = 5;
            Console.WriteLine(AbsoluteDiff(ex20Num1, ex20Num2));



        }
        private static string FrontBack(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("Value must not be empty!");
                Environment.Exit(0);
            }
            
            if (str.Length == 1) return str;

            var first = str[0];
            var last = str[str.Length - 1];
            return last + str.Substring(1, str.Length - 2) + first;
        }

        private static string FrontAndBack(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("Value must not be empty!");
                Environment.Exit(0);
            }

            if (str.Length == 1) return str;

            var first = str[0];
            
            return first.ToString().ToUpper() + str + first.ToString().ToUpper();
        }

        private static int ThreeTimes(int n1, int n2)
        {
            var sum = 0;

            if (n1 == n2)
            {
                sum = (n1 + n1) * 3;
            }
            return sum;
        }

        private static int AbsoluteDiff(int n1, int n2)
        {
            int sum = 0;
            var diffrence = n1 - n2;

            if ( n1 > n2)
            {
                sum = diffrence * 3;
            }
            return sum;
        }
    }
}
