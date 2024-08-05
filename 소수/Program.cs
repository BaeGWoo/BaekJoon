namespace 소수
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            int min = -1;
            int sum = 0;
            for (int i = first; i <= second; i++)
            {
                bool check = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        check = false;
                        break;
                    }
                }

                if (i != 1 && check)
                {
                    sum += i;
                    if (min == -1)
                    {
                        min = i;
                    }
                }
            }

            if (min == -1)
                Console.WriteLine(min);
            else
            {
                Console.WriteLine(sum);
                Console.WriteLine(min);
            }
        }
    }
}
