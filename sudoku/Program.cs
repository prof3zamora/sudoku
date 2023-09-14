using System;

class SudokuGame
{
    static void Main(string[] args)
    {
        //
        int[,] sudokuBoard = {
            {5, 3, 0, 0, 7, 0, 0, 0, 0},
            {6, 0, 0, 1, 9, 5, 0, 0, 0},
            {0, 9, 8, 0, 0, 0, 0, 6, 0},
            {8, 0, 0, 0, 6, 0, 0, 0, 3},
            {4, 0, 0, 8, 0, 3, 0, 0, 1},
            {7, 0, 0, 0, 2, 0, 0, 0, 6},
            {0, 6, 0, 0, 0, 0, 2, 8, 0},
            {0, 0, 0, 4, 1, 9, 0, 0, 5},
            {0, 0, 0, 0, 8, 0, 0, 7, 9}
        };

        Console.WriteLine("¡Bienvenido al juego de Sudoku!");
        Console.WriteLine("Llena las posiciones faltantes con números del 1 al 9.");
        Console.WriteLine();

        // Mostrar el tablero de Sudoku inicial
        PrintSudokuBoard(sudokuBoard);

        // Llenar las posiciones faltantes
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (sudokuBoard[i, j] == 0)
                {
                    int number;
                    do
                    {
                        Console.Write($"Ingresa un número en la posición [{i}][{j}]: ");
                    } while (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 9);

                    sudokuBoard[i, j] = number;
                }
            }
        }

        Console.WriteLine("¡Juego completado! Aquí está el tablero final:");
        PrintSudokuBoard(sudokuBoard);
    }

    //Imprime en consola el Tablero de Sudoku
    static void PrintSudokuBoard(int[,] board)
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}