

class Program
{
    static void Main(string[] args)
    {
        int[][] arr =
        {
            new int[]{4, 10, 12},
            new int[]{10,20},
            new int[]{4, 8, 9, 2}            
        };

        int i = 0;
        int sum = 0;
        foreach(var ar in arr)
        {
            foreach(var item in ar)
            {
                Console.Write($"{item}\t");
                if(i==1)
                    sum += item;
            }
            i++;

        }
        Console.WriteLine($"{sum}");
    }
}