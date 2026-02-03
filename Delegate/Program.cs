
namespace Delegate
{
    internal class Program
    { //single cast
        public void func1() {
            Console.WriteLine("Hello");
        }
        public delegate void mydelegate();
        //multi cast
        public void func2() {
            Console.WriteLine("fun2");
        }
        public void func3()
        {
            Console.WriteLine("fun3");
        }

        static void Main(string[] args)
        {
            Program obj=new Program();
            mydelegate del=new mydelegate(obj.func1);
            del();
            del += obj.func2;
            del();
            del += obj.func3;
            del -= obj.func2;
            del();
            //Activity :create another  function f3 and run only f1 and f3
            
        }
    }
}

