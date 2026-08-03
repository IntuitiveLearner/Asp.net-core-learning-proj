


sealed class A
{
    int res;
    public void Add(int x, int y)
    {
        res = x + y;
        Console.WriteLine($"Sum= {res}");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        A obj = new A();
        obj.Add(20, 30);
    }
}