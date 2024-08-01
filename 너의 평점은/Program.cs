namespace 너의_평점은
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] Score = new string[20][];
            string[] grade = new string[] { "A+", "A0", "B+", "B0", "C+", "C0", "D+", "D0", "F" };
            double[] gradeScore = new double[] { 4.5, 4.0, 3.5, 3.0, 2.5, 2.0, 1.5, 1.0, 0.0 };

            //학점*과목평점의 합
            double sum = 0;

            //전공평점
            double answer;

            //학점의 총합
            double pivotSum = 0;



            for (int i = 0; i < 20; i++)
            {
                Score[i] = Console.ReadLine().Split();
            }

            for (int i = 0; i < Score.Length; i++)
            {
                double curScore = float.Parse(Score[i][1]);
                double curGrade = 0;
                if (Score[i][2] != "P")
                {
                    for (int j = 0; j < grade.Length; j++)
                    {
                        if (Score[i][2] == grade[j])
                        {
                            curGrade = gradeScore[j];
                            break;
                        }
                    }

                    sum += curScore * curGrade;

                    pivotSum += curScore;
                }


            }

            answer = sum / pivotSum;
            Console.WriteLine(answer);
        }
    }
}
