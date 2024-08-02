namespace 세탁소사장_동혁
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] PriceUnit = new int[] { 25, 10, 5, 1 };
            for (int i = 0; i < number; i++)
            {
                int price = int.Parse(Console.ReadLine());


                for (int j = 0; j < PriceUnit.Length; j++)
                {
                    int temp = 0;
                    while (PriceUnit[j] * (temp + 1) <= price)
                    {
                        temp++;
                    }
                    Console.Write(temp + " ");
                    price -= PriceUnit[j] * temp;
                }
                Console.WriteLine();
            }
        }
    }
}
