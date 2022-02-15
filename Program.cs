using System;

namespace RobotAndBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Robot robot = new Robot();
                robot.Walk();
                robot.PrintLongestWalkStart();
            }catch(Exception)
            {
                Console.WriteLine("Invalid input is given!");
            }
        }
    }
}
