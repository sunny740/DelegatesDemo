using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public delegate void EventHandler(string x);
    public class EventHandling
    {
        public class Operation
        {
            public event EventHandler abc;
            public void Action(string a)
            {
                if (abc != null)
                {
                    abc(a);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine("Not Registered");
                }
            }
        }
        public static void CatchEvent(string s)
        {
            Console.WriteLine("Method calling");
        }
        public void ImplementEvent()
        {
            Operation obj = new Operation();
            obj.Action("Event Calling");
            Console.WriteLine();
            obj.abc += new EventHandler(CatchEvent);
            obj.Action("Event Called");
        }
    }
}