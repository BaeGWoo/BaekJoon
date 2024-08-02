namespace 약수_구하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int number = int.Parse(numbers[0]);
            int count = int.Parse(numbers[1]);

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    count--;

                if (count == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            if (count != 0)
                Console.WriteLine(0);
        }
    }
}
