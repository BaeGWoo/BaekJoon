namespace 분해합
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                int sum = i;
                int pivot = i;
                while (pivot > 0)
                {
                    sum += pivot % 10;
                    pivot /= 10;
                }

                if (sum == number)
                {
                    Console.WriteLine(i);
                    break;
                }

                if (i == number - 1)
                    Console.WriteLine(0);
            }
        }
    }
}
