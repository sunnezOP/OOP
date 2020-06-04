using System;
using System.Threading;

namespace lib8
{
    public class Machine
    {
        public delegate void mch();
        bool start = false;
        double petrol = 0;
        double loose_petrol = 0;
        bool pause = true;
        public void Start()
        {
            if ((start == false) && (pause == true))
            {
                start = true;
                pause = false;
                Console.WriteLine("Machine is ready, GO");
            }
            else
            {
                Console.WriteLine("Machine is already in move");
            }
        }
        public void Pause()
        {
            if (pause == false)
            {
                start = false;
                pause = true;
                Console.WriteLine("You did break");
            }
            else
            {
                Console.WriteLine("Machine is already stopped");
            }
        }
        public void Get_petrol(int a)
        {
            if (petrol+a <= 200)
            {
                petrol += a;
                Console.WriteLine($"You refueled {a} liters");
            }
            else
            {
                double rz = petrol + a - 200;
                petrol += a - rz;
                Console.WriteLine($"You got too much petrol, redundant {rz} liters");
                Console.WriteLine($"You refueled {a-rz} liters");
            }
        }
        public void go(double km) // Скорость, счет идет по 1 часу за тик
        {
            if (km <= 100)
            {
                ConsoleKeyInfo cki = new ConsoleKeyInfo();
                bool check = true;
                Console.WriteLine("To stop press S!");
                while (check == true)
                {
                    if ((km / 10 <= petrol) && (pause == false))
                    {
                        Console.WriteLine($"You drove through {km} this hour");
                        loose_petrol += km / 10;
                        petrol -= km / 10;
                        Thread.Sleep(1000);
                        if (Console.KeyAvailable == true)
                        {
                            cki = Console.ReadKey(true);
                            if (cki.Key == ConsoleKey.S)
                            {
                                Console.WriteLine("You stopped");
                                Pause();
                                check = false;
                            }
                        }

                    }
                    else if ((km / 10 > petrol) && (pause == false))
                    {
                        Console.WriteLine($"Not enough petrol, you need refile {km / 10 - petrol} litres");
                        check = false;
                        Pause();

                    }
                }
            }
            else
            {
                Console.WriteLine("You are so fast");
            }

        }
        public void info_petrol()
        {
            Console.WriteLine(loose_petrol);
        }
        public void swap()
        {
            mch tts;
            if (pause != false)
            {
                tts = Start;
            }
            else
            {
                tts = Pause;
            }
            tts.Invoke();
        }

    }
}
