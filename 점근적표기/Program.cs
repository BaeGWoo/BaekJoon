namespace 점근적표기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);

            int c = int.Parse(Console.ReadLine());

            int min = int.Parse(Console.ReadLine());
            int temp = c - a;
            if (temp == 0)
            {
                if (b <= 0)
                {
                    Console.WriteLine(1);
                }

                else
                {
                    Console.WriteLine(0);
                }
            }

            else if (temp >= 0)
            {
                double pivot = (b * 1.0) / temp;

                if (pivot <= min)
                    Console.WriteLine(1);
                else
                {
                    Console.WriteLine(0);
                }
            }

            else
            {

                Console.WriteLine(0);

            }
        }
    }
}
