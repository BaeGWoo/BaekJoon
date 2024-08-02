namespace 진법교환2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long number = int.Parse(input[1]);
            string answer = "";

            long cur = int.Parse(input[0]);
            int level = 1;
            long pivot = number;
            while (pivot <= cur)
            {
                pivot *= number;
                level++;
            }

            for (int i = 0; i < level; i++)
            {
                long temp = 1;
                for (int j = 0; j < level - i - 1; j++)
                {
                    temp *= number;
                }
                int count = 0;
                while (temp * (count + 1) <= cur)
                {

                    count++;
                }
                if (count >= 10)
                {

                    answer += (char)('A' + (count - 10));

                }
                else
                {
                    answer += count;
                }
                cur -= (temp * count);
            }

            Console.WriteLine(answer);
        }
    }
}
