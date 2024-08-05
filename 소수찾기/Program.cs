namespace 소수찾기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int result = 0;
            string[] numbers = Console.ReadLine().Split();

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(numbers[i]);
                bool check = true;
                for (int j = 2; j < number; j++)
                {
                    if (number % j == 0)
                    {
                        check = false;
                        break;
                    }
                }
                if (number != 1 && check)
                {
                    result++;
                }
            }

            Console.WriteLine(result);

        }
    }
}
