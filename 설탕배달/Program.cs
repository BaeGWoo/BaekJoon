namespace 설탕배달
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sugar = int.Parse(Console.ReadLine());

            int count3 = 0;
            int count5 = 0;


            count5 = sugar / 5;
            int temp = sugar % 5;
            // 1. sugar 전체 무게를 8로 나눈다.
            // 2. 나머지 무게를 5나 3으로 나누어서 떨어지게 한다.
            // 3. 나누어 떨어지지 않을 경우 8을 하나 빌려온다.
            // 4. 이후 count8이 음수가 되기 전까지 과정을 반복해서 음수가 되면 -1을 반환한다.
            while (count5 >= 0)
            {
                if (temp % 3 == 0)
                {
                    count3 += (temp / 3);
                    temp %= 3;
                    break;
                }

                else
                {
                    count5--;
                    temp += 5;
                }
            }

            if (temp != 0)
                Console.WriteLine(-1);
            else
                Console.WriteLine(count3 + count5);
        }
    }
}
