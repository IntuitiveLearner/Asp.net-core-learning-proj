


class Program
{
    static void Main(string[] args)
    {
        int[] arr = {1, 2 ,3 , 54, 57};
        int sum = 0;

        foreach(var item in arr)
        {
            sum += item;
        }
        Console.WriteLine($"Sum is {sum}");
    }
}