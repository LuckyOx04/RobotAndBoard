using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAndBoard
{
    class Board
    {
        Random r = new Random();
        char[,] field;

        public Board(int n, int m)
        {
            field = new char[n, m];

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = IntToChar(r.Next(4));
                }
            }
        }

        public void PrintBoard()
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write($"[{field[i, j]}]");
                }
                Console.WriteLine();
            }
        }

        public bool OutOfBoard(int x, int y)
        {
            return x < 0 || x == field.GetLength(1) || y < 0 || y == field.GetLength(0);
        }

        public char ReturnCommand(int x, int y)
        {
            return field[y, x];
        }

        public int GetFieldLength(int dimension)
        {
            if(dimension == 0)
            {
                return field.GetLength(0);
            }
            else
            {
                return field.GetLength(1);
            }
        }

        char IntToChar(int num)
        {
            switch (num)
            {
                case 0:
                    return 'U';
                case 1:
                    return 'D';
                case 2:
                    return 'L';
                case 3:
                    return 'R';
                default:
                    return 'N';
            }
        }
    }
}
