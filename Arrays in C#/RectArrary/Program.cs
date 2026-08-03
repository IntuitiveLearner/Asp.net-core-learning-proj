


class Program
{
    static void Main()
    {
        // 2D Array - Rectangular
        // int[,] = new int[3,2];

        int[,] arr =
        {
            {20, 30, 40},
            {2, 34, 54},
            {22, 45, 23}
        };
        
        int sum = 0;
        for(int i=0; i<3; i++)
        {
            for(int j=0; j<3; j++)
            {
                Console.Write($"{arr[i,j]} \t");
                if(i == 1)
                    sum += arr[i,j];
            }
            Console.WriteLine("");
        }
            Console.WriteLine($"Sum is {sum}.");
    }
}