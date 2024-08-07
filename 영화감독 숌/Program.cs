namespace 영화감독_숌
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //666다음의 수는 1씩 증가해서 그 다음으로 6이 연속해서 3번이상 나오게 되는 수
            int count = int.Parse(Console.ReadLine());
            int number = 666;
            while (count > 0)
            {

                string temp = "" + number;
                int[] stack = new int[temp.Length];
                for (int i = 0; i < stack.Length; i++)
                {
                    stack[i] = (int)(temp[i] - '0');
                }
               
                for (int i = 0; i < stack.Length - 2; i++)
                {
                    if (stack[i] == 6 && stack[i + 1] == 6 && stack[i + 2] == 6)
                    {
                        count--;
                        break;
                    }
                }
                number++;

            }
            Console.WriteLine(number - 1);

        }
    }
}
