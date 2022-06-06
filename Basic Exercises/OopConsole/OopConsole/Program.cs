using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person user0 = new Person();

            user0.FirstName = "Stephen";
            user0.LastName = "Cutts";

            Console.WriteLine(user0.Introduce()); 
        }
    }
}
