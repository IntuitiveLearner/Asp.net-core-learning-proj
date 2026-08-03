

partial class A
{
    public void Add (int x, int y)
    {
        int res = x+y;
        Console.WriteLine($"Sum={res}");
    }
}

partial class A
{
    public void Diff(int x, int y)
    {
        int res = x-y;
        Console.WriteLine($"Difference={res}");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        A obj = new A();
        obj.Add(30, 20);
        obj.Diff(30, 20);
    }
}