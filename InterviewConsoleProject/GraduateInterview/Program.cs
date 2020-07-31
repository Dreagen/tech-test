using System;

namespace GraduateInterview
{
    class Program
    {
        private const int NUM_DOORS = 3;
        private readonly static Random Random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Running Games");

            int wins = 0;
            int losses = 0;

            for (int i = 0; i < 1000000; ++i)
            {
                bool win = RunGame();

                if (win)
                    ++wins;
                else
                    ++losses;

            }

            Console.WriteLine("Wins: {0}, Losses: {1}", wins, losses);

            Console.ReadKey();
        }

        private static bool RunGame()
        {
            return false;
        }

        private static int GetRandomDoor()
        {
            return Random.Next(NUM_DOORS);
        }
    }
}
