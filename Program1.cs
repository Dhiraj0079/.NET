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
            string name = fname+" " + lname;
            Console.WriteLine(name);
            int d = 10;
            Console.WriteLine(c+d);
            Console.WriteLine("My name is \"Dhiraj Regade\" and I am from Ichalakaranji");
            float f = 2.345F;
            Console.WriteLine(f);
            int a =(int) f;//Explicit type casting
            Console.WriteLine(a);
            double b = f;//Impicit type casting
            Console.WriteLine(b);
            //User Input
            Console.WriteLine("Enter your name");
            String sname = Console.ReadLine();
            Console.WriteLine( "Hello "+ sname);
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is " + age);
            //operators
            Console.WriteLine(c > d);
            //Math
            Console.WriteLine(Math.Min(c,d));
            Console.WriteLine(Math.Round(f));
            Console.WriteLine(Math.Max(c, d));
            Console.WriteLine(Math.Abs(-4.7));
            Console.WriteLine(Math.Sqrt(9801));
            string txt = "Hello World";
            Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt.ToLower());
            String fullname = $" My full name is :{fname} {lname}";
            Console.WriteLine(fullname);
            int index=name.IndexOf("R");
            Console.WriteLine(index);
            String lastname=name.Substring(index);
            Console.WriteLine(lastname);
            //short hand if else
            String result = (c > d) ? "c is greater than d" : "d is greater than c";
            Console.WriteLine(result);
            MyMethod();

           



        }
    }
}
