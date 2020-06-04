using System;
using Class1;

namespace lab8_final
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1.Machine.Notify += DisplayMessage;
            Machine machine = new Machine();
            machine.Pause();
            machine.Start();
            machine.Get_petrol(30);
            machine.go(100);
            machine.info_petrol();
            machine.swap();

        }
        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
