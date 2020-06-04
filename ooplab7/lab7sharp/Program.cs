using System;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();
            ll.AppendFirst(1.1);
            ll.AppendFirst(-2.2);
            ll.AppendFirst(3.2);
            ll.AppendFirst(4.1);
            ll.Remove(2.2);

            Console.WriteLine("List: ");
            foreach (var item in ll)
            {
                Console.WriteLine("{0:0.##}", item);
            }

            Console.WriteLine($"Number of elements bigger than avg - {ll.NumberOfElementsBiggerThanAvg()}");
            ll.Removenegative();
            Console.WriteLine("List after deleting negative items:");
            foreach (var item in ll)
            {
                Console.WriteLine("{0:0.##}", item);
            }
        }
    }
}