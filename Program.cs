using System;

namespace RobotAndBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            robot.Walk();
            robot.PrintLongestWalkStart();
        }
    }
}
