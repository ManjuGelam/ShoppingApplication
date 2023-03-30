using System;

namespace ShoppingApplication
{

    internal class PartialClass
    {
        public void Method1()
        {
            Console.WriteLine("KIDS WEAR");
        }
        public void Method2()
        {
            Console.WriteLine("MENS WEAR");
        }
    }
    partial class parts
    {
        public void Method3()
        {
            Console.WriteLine("LADIES WEAR");
        }
        public void Method4()
        {
            Console.WriteLine("CLOTHING");
        }
    }
    internal class Collection
    {
        static void Main()
        {
            PartialClass c = new PartialClass();
            PartialClass c1 = new PartialClass();
            c.Method1(); c.Method2();
            Console.ReadLine();
        }
    }
}