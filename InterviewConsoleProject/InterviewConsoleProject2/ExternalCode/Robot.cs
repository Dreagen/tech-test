using System;

namespace InterviewConsoleProject2.ExternalCode
{
    // YOU CANNOT CHANGE THIS FILE
    public sealed class Robot : IRobot
    {
        public void Move(float distance, float speed)
        {
            Console.WriteLine(string.Format("Moving robot {0}m at {1}m/s", distance, speed));
        }

        public void Rotate(float angle)
        {
            Console.WriteLine(string.Format("Rotating robot by {0} degrees", angle));
        }

        public void Beep()
        {
            Console.WriteLine("Beep!");
        }
    }
}
