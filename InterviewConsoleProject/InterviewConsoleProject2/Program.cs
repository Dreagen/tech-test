using System;

using InterviewConsoleProject2.ExternalCode;

namespace InterviewConsoleProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();

            RobotRecorder recorder = new RobotRecorder();

            Console.WriteLine("Hit any record to run robot program.");
            Console.WriteLine("");
            Console.ReadKey();
            RobotProgram.Execute(robot);
            Console.WriteLine("");

            Console.WriteLine("Hit any key to replay.");
            Console.WriteLine("");
            Console.ReadKey();

            recorder.Replay();

            Console.WriteLine("");
            Console.WriteLine("Hit any key to exit.");
            Console.ReadKey();
        }
    }
}
