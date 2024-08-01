namespace 분수찾기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int first;
            int second;

            int firstplus = 1;
            int secondplus = 1;

            int level = 1;
            int start = 1;

            while (true)
            {
                if (number > start + level + 1)
                {
                    start += (++level);
                }

                else
                {
                    if (number - start > 0)
                        level++;
                    break;
                }
            }

            if (level % 2 == 0)
            {
                first = 1;
                second = level;

                secondplus = -1;
            }

            else
            {
                first = level;
                second = 1;

                firstplus = -1;
            }

            for (int i = 1; i < number - start; i++)
            {
                first += firstplus;
                second += secondplus;
            }



            Console.WriteLine(first + "/" + second);

        }
    }
}
