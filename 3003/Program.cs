namespace _3003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[6];


            string[] N = (Console.ReadLine().Split());

            for (int i = 0; i < N.Length; i++)
            {

                number[i] = int.Parse(N[i]);

            }

            int[] arr = new int[] { 1, 1, 2, 2, 2, 8 };

            for (int i = 0; i < 6; i++)
            {
                int result = arr[i] - number[i];
                Console.Write(result);
                if (i != 5)
                    Console.Write(" ");

            }
        }
    }
}
