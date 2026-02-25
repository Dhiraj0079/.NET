using System;

namespace Practice
{
    internal class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int c = 5;
            Console.WriteLine(c);

            string fname = "Dhiraj";
            string lname = "Regade";
            string name = fname + " " + lname;
            Console.WriteLine(name);

            int d = 10;
            Console.WriteLine(c + d);

            Console.WriteLine("My name is \"Dhiraj Regade\" and I am from Ichalakaranji");

            float f = 2.345F;
            Console.WriteLine(f);

            int a = (int)f; // Explicit type casting
            Console.WriteLine(a);

            double b = f; // Implicit type casting
            Console.WriteLine(b);

            // User Input
            Console.WriteLine("Enter your name");
            string sname = Console.ReadLine();
            Console.WriteLine("Hello " + sname);

            Console.WriteLine("Enter your age");
            int age;
            if (int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Your age is " + age);
            }
            else
            {
                Console.WriteLine("Invalid age entered");
            }

            // Operators
            Console.WriteLine(c > d);

            // Math
            Console.WriteLine(Math.Min(c, d));
            Console.WriteLine(Math.Round(f));
            Console.WriteLine(Math.Max(c, d));
            Console.WriteLine(Math.Abs(-4.7));
            Console.WriteLine(Math.Sqrt(9801));

            // String methods
            string txt = "Hello World";
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToLower());

            string fullname = $"My full name is: {fname} {lname}";
            Console.WriteLine(fullname);

            // Safe substring usage
            int index = name.IndexOf("R");

            if (index != -1)
            {
                string lastname = name.Substring(index);
                Console.WriteLine(lastname);
            }
            else
            {
                Console.WriteLine("Character not found");
            }

            // Short-hand if-else (ternary operator)
            string result = (c > d) ? "c is greater than d" : "d is greater than c";
            Console.WriteLine(result);

            MyMethod();

            Console.ReadKey(); // Keeps terminal open
            //how to deploy code in .net
            //class to class and method to method commu working
            //cummu bet class obj
            //reusability code 
            //inbuilt packages
            //how to use DDL
            //c# +ADO .net coonectivity
            Calculator calc = new Calculator();
            int result = calc.Add(5, 10);
            Console.WriteLine(result);
        }
    }
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

}
