namespace 배수와_약수
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] numbers = Console.ReadLine().Split();
                int first = int.Parse(numbers[0]);
                int second = int.Parse(numbers[1]);
                if (first == 0 && second == 0)
                {
                    break;
                }

                if (first < second)
                {
                    if (second % first == 0)
                        Console.WriteLine("factor");
                    else
                        Console.WriteLine("neither");
                }

                else
                {
                    if (first % second == 0)
                        Console.WriteLine("multiple");
                    else
                        Console.WriteLine("neither");
                }
            }
        }
    }
}
