namespace 진법변환
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int number = int.Parse(input[1]);
            long answer = 0;

            for (int i = 0; i < input[0].Length; i++)
            {
                long cur = (long)(input[0][i] - '0');
                if (cur >= 10)
                {
                    cur = (int)(input[0][i]) - (int)'A';
                    cur += 10;
                }

                for (int j = 0; j < input[0].Length - 1 - i; j++)
                {
                    cur *= number;
                }
                answer += cur;
            }

            Console.WriteLine(answer);
        }
    }
}
