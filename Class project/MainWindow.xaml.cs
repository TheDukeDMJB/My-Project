using Connect4;
using System;

class Connect4
{
    const int ROWS = 6;
    const int COLUMNS = 7;

    static int[,] board = new int[ROWS, COLUMNS];

    static int currentPlayer = 1;

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Connect 4!");

        bool gameOver = false;

        while (!gameOver)
        {
            PrintBoard();

            int column = GetNextMove();

            int row = GetNextEmptyRow(column);

            board[row, column] = currentPlayer;

            if (CheckForWin(row, column))
            {
                Console.WriteLine("Player {0} wins!", currentPlayer);
                gameOver = true;
            }
            else if (CheckForDraw())
            {
                Console.WriteLine("Draw!");
                gameOver = true;
            }

            currentPlayer = 3 - currentPlayer;
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    static void PrintBoard()
    {
        Console.Clear();
        for (int row = ROWS - 1; row >= 0; row--)
        {
            for (int col = 0; col < COLUMNS; col++)
            {
                Console.Write("|");
                if (board[row, col] == 0)
                {
                    Console.Write(" ");
                }
                else if (board[row, col] == 1)
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write("O");
                }
            }
            Console.Write("|\n");
        }
        Console.WriteLine(" 1 2 3 4 5 6 7 ");
    }

    static int GetNextMove()
    {
        while (true)
        {
            Console.Write("Player {0}, please enter a column (1-7): ", currentPlayer);
            string input = Console.ReadLine();
            int column;
            if (int.TryParse(input, out column) && column >= 1 && column <= 7 && board[ROWS - 1, column - 1] == 0)
            {
                return column - 1;
            }
            Console.WriteLine("Invalid move, please try again.");
        }
    }

    static int GetNextEmptyRow(int column)
    {
        for (int row = 0; row < ROWS; row++)
        {
            if (board[row, column] == 0)
            {
                return row;
            }
        }
        return -1; // column is full
    }

    private static bool CheckForWin(int row, int column)
    {
        // check horizontal
        int count = 0;
        for (int col = 0; col < COLUMNS; col++)
        {
            if (board[row, col] == currentPlayer)
            {
                count++;
            }
            else
            {
                count = 0;
            }
            if (count >= 4)
            {
                return true;
            }
        }

        // check vertical
        count = 0;
        for (int r = 0; r < ROWS; r++)
        {
            if (board[r, column] == currentPlayer)
            {
                count++;
            }
            else
            {
                count = 0;
            }
            if (count >= 4)
            {
                return true;
            }
        }

        // check diagonal
        count = 0;
        for (int i = -3; i <= 3; i++)
        {
            int r = row + i;
            int c = column + i;
        }

        private bool IsBoardFull()
        {
            for (int row = 0; row < ROWS; row++)
            {
                for (int column = 0; column < COLUMNS; column++)
                {
                    if (board[row, column] == DiscType.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
