namespace 네번째_점
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] shapes = new int[3, 2];
            for (int i = 0; i < 3; i++)
            {
                string[] position = Console.ReadLine().Split();
                shapes[i, 0] = int.Parse(position[0]);
                shapes[i, 1] = int.Parse(position[1]);

            }


            int x = shapes[0, 0];
            int y = shapes[0, 1];

            x = shapes[0, 0] == shapes[1, 0] ? shapes[2, 0] : shapes[0, 0] == shapes[2, 0] ? shapes[1, 0] : shapes[0, 0];
            y = shapes[0, 1] == shapes[1, 1] ? shapes[2, 1] : shapes[0, 1] == shapes[2, 1] ? shapes[1, 1] : shapes[0, 1];

            Console.WriteLine(x + " " + y);
        }
    }
}
