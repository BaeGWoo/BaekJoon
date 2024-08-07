namespace ConsoleApp1
{
    internal class Program
    {

        static void Sort(ref long[] numbers,long start,long end)
        {
            if (end - start <= 1)
                return;

            long pivotNum = numbers[start];
            long pivot = start;
            long leftindex = start+1;
            long rightindex = end;

          

            long cur = numbers[start];
            numbers[start] = numbers[rightindex];
            numbers[rightindex] = cur;

            
          

            Sort(ref numbers, start, rightindex-1);
            Sort(ref numbers, rightindex+1, end);
        }


        static void Main(string[] args)
        {
            long count = long.Parse(Console.ReadLine());
            long[] numbers = new long[count];
            for (long i = 0; i < count; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            long start = 0;
            long end = count;
            

            Sort(ref numbers, start, end-1);

            for (long i = 0; i < count; i++)
            {
                Console.WriteLine(numbers[i]);
            }




        }
    }
}
