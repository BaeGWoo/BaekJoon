namespace 크로아티아알파벳
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] alphabet = new string[] { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
            string pivot = Console.ReadLine();
            int result = 0;

            for (int i = 0; i < pivot.Length; i++)
            {
                bool alphabetCheck = true;
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (alphabet[j][0] == pivot[i])
                    {
                        bool check = true;
                        for (int s = 0; s < alphabet[j].Length; s++)
                        {
                            if (i + s > pivot.Length)
                            {
                                check = false;
                                break;
                            }

                            if (pivot[i + s] != alphabet[j][s])
                            {
                                check = false;
                                break;
                            }
                        }

                        if (check)
                        {
                            i += (alphabet[j].Length - 1);
                            result++;
                            alphabetCheck = false;
                            break;
                        }
                    }
                }
                if (alphabetCheck)
                    result++;
            }

            Console.WriteLine(result);
        }
    }
}
