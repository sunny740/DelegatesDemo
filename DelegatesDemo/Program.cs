using System;
namespace DelegatesDemo
{
    public delegate int Operation(int x, int y);
    class program
    {
        static int Addition(int a, int b)
        {
            return a + b;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Delegate POC!");   // (Singlecast delegates)
            Operation obj = new Operation(Addition);      // (Single)
            Console.WriteLine("Addition is ={0}", obj(12, 15));  //(Single)
            Console.WriteLine();  // (Single)

            //MultiCastDelegates.ImplementDelegate(); //(Multicast)

            EventHandling Eventhandling = new EventHandling();
            Eventhandling.ImplementEvent();
        }
    }
}
