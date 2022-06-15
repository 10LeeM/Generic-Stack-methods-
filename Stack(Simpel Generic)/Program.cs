using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Simpel_Generic_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Create a new stack
                Stack<string> orders = new();
                orders.Push("SO 001");
                orders.Push("SO 002");
                orders.Push("SO 003");
                orders.Push("SO 004");
                orders.Push("SO 005");
                orders.Push("SO 006");
                orders.Push("SO 007");

                //Enumarate the orders without disturbing its contents
                Console.WriteLine("Sales orders");

                foreach (string order in orders)
                {
                   
                    Console.WriteLine(order);
                }

                Console.WriteLine("\nPopping {0}", orders.Pop());
                Console.WriteLine("Peek at next item to destack:{0}", orders.Peek());

                //Create a copy of the stack using ToArray method
                Stack<string> orders2 = new(orders.ToArray());
                Console.WriteLine("Content of the first order batch are");

                foreach (string order in orders2)
                {
                    Console.WriteLine(order);

                }

                //Clear oreder2 contents
                Console.WriteLine("\nOrders2.clear()");
                orders2.Clear();

                //Get the number of elements conatined in the stack after clearing
                Console.WriteLine("\nCount orders2 batch {0}", orders2.Count);

                Console.ReadKey();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
