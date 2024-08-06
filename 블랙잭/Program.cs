namespace 블랙잭
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int n = int.Parse(numbers[0]);
            int pivot = int.Parse(numbers[1]);

            string[] card = Console.ReadLine().Split();
            int max = int.Parse(card[0]) + int.Parse(card[1]) + int.Parse(card[2]);

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        int n1 = int.Parse(card[i]);
                        int n2 = int.Parse(card[j]);
                        int n3 = int.Parse(card[k]);

                        int sum = n1 + n2 + n3;
                        if (sum <= pivot)
                        {
                            if (max < sum || max > pivot)
                                max = sum;
                        }
                    }
                }
            }


            Console.WriteLine(max);
        }
    }
}
