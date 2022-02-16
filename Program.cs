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
                robot.GetLongestStart();
                robot.PrintLongestWalkStart();
            }catch(Exception)
            {
                Console.WriteLine("Invalid input is given!");
            }
        }
    }
}
