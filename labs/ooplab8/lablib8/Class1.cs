using System;
using System.Threading;

namespace Class1
{
    public class Machine
    {
        public delegate void mch();
        bool start = false;
        double petrol = 0;
        double loose_petrol = 0;
        bool pause = true;
        public delegate void Message(string message);
        public static event Message Notify;
        public void Start()
        {
            if ((start == false) && (pause == true))
            {
                start = true;
                pause = false;
                Notify?.Invoke("Machine is ready, GO");
            }
            else
            {
                Notify?.Invoke("Machine is already in move");
            }
        }
        public void Pause()
        {
            if (pause == false)
            {
                start = false;
                pause = true;
                Notify?.Invoke("You did break");
            }
            else
            {
                Notify?.Invoke("Machine is already stopped");
            }
        }
        public void Get_petrol(int a)
        {
            if (petrol + a <= 200)
            {
                petrol += a;
                Notify?.Invoke($"You refueled {a} liters");
            }
            else
            {
                double rz = petrol + a - 200;
                petrol += a - rz;
                Notify?.Invoke($"You refueled {a - rz} liters");
            }
        }
        public void go(double km) // Скорость, счет идет по 1 часу за тик
        {
            if (km <= 100)
            {
                ConsoleKeyInfo cki = new ConsoleKeyInfo();
                bool check = true;
                Notify?.Invoke("To stop press S!");
                while (check == true)
                {
                    if ((km / 10 <= petrol) && (pause == false))
                    {
                        Notify?.Invoke($"You drove through {km} this hour");
                        loose_petrol += km / 10;
                        petrol -= km / 10;
                        Thread.Sleep(1000);
                        if (Console.KeyAvailable == true)
                        {
                            cki = Console.ReadKey(true);
                            if (cki.Key == ConsoleKey.S)
                            {
                                Notify?.Invoke("You stopped");
                                Pause();
                                check = false;
                            }
                        }

                    }
                    else if ((km / 10 > petrol) && (pause == false))
                    {
                        Notify?.Invoke($"Not enough petrol, you need refile {km / 10 - petrol} litres");
                        check = false;
                        Pause();

                    }
                }
            }
            else
            {
                Notify?.Invoke("You re so fast");
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
