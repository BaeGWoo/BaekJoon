namespace 세_막대
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int first = int.Parse(numbers[0]);
            int second = int.Parse(numbers[1]);
            int third = int.Parse(numbers[2]);


            int pivot = first > second ? first > third ? first : third : second > third ? second : third;

            int sum = first + second + third;
            sum -= pivot;

            if (pivot >= sum)
            {
                Console.WriteLine(sum + sum - 1);
            }

            else
            {
                Console.WriteLine(sum + pivot);
            }

        }
    }
}
