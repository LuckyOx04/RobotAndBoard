using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAndBoard
{
    class Robot
    {
        int n, m;
        (int x, int y) coordinate;
        int count = 0;
        int maxCount = 0;
        (int x, int y) longestWalkStart;

        List<(int, int)> alreadyStepped;

        Board board;
        public Robot()
        {
            Console.Write("Enter number of rows: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            m = int.Parse(Console.ReadLine());

            alreadyStepped = new List<(int, int)>();

            board = new Board(n, m);

            board.PrintBoard();
        }

        //Prints the coordinates of the square from which the
        //longest walk started
        public void PrintLongestWalkStart()
        {
            int x, y;
            x = longestWalkStart.x;
            y = longestWalkStart.y;
            Console.WriteLine($"Longest walk start is: {y}, {x}");
        }

        //Reads a command and moves the robot
        void Move(char command)
        {
            switch (command)
            {
                case 'U':
                    coordinate.y -= 1;
                    count++;
                    break;
                case 'D':
                    coordinate.y += 1;
                    count++;
                    break;
                case 'L':
                    coordinate.x -= 1;
                    count++;
                    break;
                case 'R':
                    coordinate.x += 1;
                    count++;
                    break;
            }
        }

        //The robot walks until it gets out of the board
        //or it steps on an already stepped square and if
        //that walk was the longest the start coordinates are saved.
        void Walk(int i, int j)
        {
            while (!board.OutOfBoard(coordinate.x, coordinate.y) && !alreadyStepped.Contains((coordinate.x, coordinate.y)))
            {
                alreadyStepped.Add((coordinate.x, coordinate.y));
                Move(board.ReturnCommand(coordinate.x, coordinate.y));
            }

            if (count > maxCount)
            {
                maxCount = count;
                longestWalkStart.x = j;
                longestWalkStart.y = i;
            }
            count = 0;
            alreadyStepped.Clear();
        }

        //Starts walking from each square
        public void GetLongestStart()
        {
            for(int i = 0; i < board.GetFieldLength(0); i++)
            {
                for(int j = 0; j < board.GetFieldLength(1); j++)
                {
                    coordinate.x = j;
                    coordinate.y = i;

                    Walk(i, j);
                }
            }
        }
    }
}
