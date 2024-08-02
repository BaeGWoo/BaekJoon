namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                int number=int.Parse(Console.ReadLine());
                int sum = 0;

                if (number == -1)
                    break;

                Queue<int> q = new Queue<int>();
                for(int i =1; i < number; i++)
                {
                    if(number%i==0)
                    {
                        q.Enqueue(i);
                        sum += i;
                    }
                }
                if (sum == number)
                {
                    Console.Write(number + " = 1");
                    q.Dequeue();
                    while(q.Count > 0)
                    {
                        Console.Write(" + ");
                        int cur=q.Dequeue();
                        
                        Console.Write(cur);  
                    }
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine(number + " is NOT perfect.");
                }
            }

        }
    }
}
