using System;
namespace StopWatch
{
    class StopWatch
    {
        private int seconds = 0;
        private int minutes = 0;
        private int hours = 0;
        private bool running = true;


        private void Intro()
        {
            Console.WriteLine("HELLO I AM A STOPWATCH !! ");
            Console.WriteLine("Press SPACEBAR to start or Backspace to exit...");
            //Console.ReadKey();
            //Console.Clear();

        }

        public void Start()
        {

            while (running)
            {
                Intro();

                if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    Stop();
                    seconds = 0;
                    minutes = 0;
                }
                else if (Console.ReadKey(true).Key == ConsoleKey.Backspace)
                {
                    Exit();
                    break;
                }

            }


        }
        private void Stop()
        {
            Console.Clear();
            Console.WriteLine("Press ESC to stop");


            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
            {
                Console.Write("\r Time: {00}:{1}:{2}", hours, minutes, seconds);
                if (seconds == 60)
                {
                    minutes++;
                    seconds = 0;
                }
                System.Threading.Thread.Sleep(1000);
                seconds++;

            }

            Console.WriteLine("\nPress any key to continue:");
            Console.ReadKey();
            Console.Clear();


        }

        private void Exit()
        {
            Console.Clear();
            Console.WriteLine("GOODBYE ILL TIME YOU LATER :-)");
            Console.ReadKey();
        }
    }
}
