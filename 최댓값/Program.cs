namespace 최댓값
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] numbers = new string[9][];
            int row = 1;
            int col = 1;
            for (int i = 0; i < 9; i++)
            {
                numbers[i] = Console.ReadLine().Split();
            }

            int max = int.Parse(numbers[0][0]);

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (int.Parse(numbers[i][j]) > max)
                    {
                        max = int.Parse(numbers[i][j]);
                        row = i + 1;
                        col = j + 1;
                    }
                }
            }

            Console.WriteLine(max);
            Console.Write(row + " " + col);

        }
    }
}
