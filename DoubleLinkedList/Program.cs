using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> List= new LinkedList<string>();
            List.AddFirst("first");
            List.AddFirst("second");
            List.AddFirst("third");
            List.AddFirst("fourth");
            List.AddFirst("fifth");
            List.AddFirst("sixth");
            List.AddFirst("seventh");
            List.AddFirst("eighth");

            List.WriteListFromTheFirst(List.First);
            List.Reverse();

            List.WriteListFromTheFirst(List.First);
            Console.ReadKey();
        }
       
    }
}
