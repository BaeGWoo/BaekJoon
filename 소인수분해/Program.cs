namespace 소인수분해
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int index = 2;
            while (number > 1)
            {
                if (number % index == 0)
                {
                    number /= index;
                    Console.WriteLine(index);
                }

                else
                    index++;
            }

        }
    }
}
