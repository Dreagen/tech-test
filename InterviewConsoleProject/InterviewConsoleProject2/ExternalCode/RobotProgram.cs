namespace InterviewConsoleProject2.ExternalCode
{
    // YOU CANNOT CHANGE THIS FILE
    public static class RobotProgram
    {
        public static void Execute(IRobot robot)
        {
            robot.Beep();
            robot.Move(10f, 3f);
            robot.Rotate(5f);
            robot.Beep();
            robot.Move(15f, 5f);
            robot.Beep();       
        }
    }
}
