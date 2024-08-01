namespace 행렬덧셈
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] MatrixNumber = Console.ReadLine().Split();
            int row = int.Parse(MatrixNumber[0]);
            int col = int.Parse(MatrixNumber[1]);

            string[][] matrixA = new string[row][];
            string[][] matrixB = new string[row][];
            int[,] matrixC = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                matrixA[i] = Console.ReadLine().Split();
            }

            for (int i = 0; i < row; i++)
            {
                matrixB[i] = Console.ReadLine().Split();
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrixC[i, j] = int.Parse(matrixA[i][j]) + int.Parse(matrixB[i][j]);
                    Console.Write(matrixC[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
