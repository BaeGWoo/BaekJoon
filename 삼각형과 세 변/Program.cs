namespace 삼각형과_세_변
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
                int third = int.Parse(numbers[2]);

                if (first == 0 && second == 0 && third == 0)
                    break;
                int pivot = first > second ? first > third ? first : third : second > third ? second : third;

                if (first + second + third - pivot > pivot)
                {
                    if (first == second && second == third)
                    {
                        Console.WriteLine("Equilateral");
                    }

                    else if (first == second || second == third || first == third)
                    {
                        Console.WriteLine("Isosceles");
                    }

                    else
                    {
                        Console.WriteLine("Scalene");
                    }
                }

                else
                {
                    {
                        Console.WriteLine("Invalid");
                    }
                }
            }
        }
    }
}
