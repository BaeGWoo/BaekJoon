namespace ConsoleApp1
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
           long n=long.Parse(Console.ReadLine());

            long result=0;
            long index = n - 2;
            for(long i = 1; i <= n - 2; i++)
            {
                result += i * (index--);
            }
            
            Console.WriteLine(result);
            Console.WriteLine(3);
           


        }
    }
}
