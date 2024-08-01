namespace 중앙이동알고리즘
{
    internal class Program
    {
        static int Number(int n)
        {
            if (n == 0)
                return 2;
            else
                return Number(n - 1) * 2 - 1;
        }

        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            //int start = 2;

            //for(int i = 0; i < number; i++)
            //{
            //    start +=start - 1;
            //}
            //Console.WriteLine(start*start);
            int answer = Number(number);
            Console.WriteLine(answer * answer);

        }
    }
}
