namespace 체스판_다시_칠하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] matrix = Console.ReadLine().Split();
            int row = int.Parse(matrix[0]);
            int col = int.Parse(matrix[1]);

            char[][] board = new char[row][];
            for (int i = 0; i < row; i++)
            {
                board[i] = new char[col];
                string temp = Console.ReadLine();
                for (int j = 0; j < temp.Length; j++)
                {
                    board[i][j] = temp[j];
                }
            }

            int count = 0;
            int Rcount = 0;
            int min = -1;


            char startPoint = 'B';
            char RstartPoint = 'W';
            for (int s = 0; s <= row - 8; s++)
            {
                for (int k = 0; k <= col - 8; k++)
                {
                    for (int i = s; i < s + 8; i++)
                    {
                        for (int j = k; j < k + 8; j++)
                        {
                            if (board[i][j] != startPoint)
                            {
                                count++;
                            }
                            if (board[i][j] != RstartPoint)
                            {
                                Rcount++;
                            }

                            if (j != k + 7)
                            {
                                char temp = startPoint;
                                startPoint = RstartPoint;
                                RstartPoint = temp;
                            }

                        }
                    }
                    if (count < min || min == -1)
                        min = count;
                    if (Rcount < min)
                        min = Rcount;
                    count = 0;
                    Rcount = 0;
                }
            }


            Console.WriteLine(min);
        }
    }
}
