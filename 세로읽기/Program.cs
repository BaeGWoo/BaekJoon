namespace 세로읽기
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] str = new string[5];
            string answer = "";
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Console.ReadLine();
            }


            for (int index = 0; ; index++)
            {
                int count = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i].Length > index)
                    {
                        answer += str[i][index];
                    }

                    else
                        count++;
                }
                if (count >= 5)
                    break;
            }

            Console.WriteLine(answer);

        }
    }
}
