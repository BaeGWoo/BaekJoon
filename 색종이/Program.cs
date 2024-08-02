namespace 색종이
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[100, 100];

            int number = int.Parse(Console.ReadLine());
            int[] pair = new int[2];
            int answer = 0;

            for (int i = 0; i < number; i++)
            {
                string[] temp = Console.ReadLine().Split();
                pair[0] = int.Parse(temp[0]);
                pair[1] = int.Parse(temp[1]);

                for (int s = pair[0]; s < pair[0] + 10; s++)
                {
                    for (int k = pair[1]; k < pair[1] + 10; k++)
                    {
                        matrix[s, k] = 1;
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        answer++;
                    }
                }
            }

            Console.WriteLine(answer);
        }
    }
}
