// Lambda Expression '=>'
// Anonymous fn using lambda expn

class A
{
    public int Add(int x, int y) => x+y;
}
class Program
{
    static void Main(string[] args)
    {
        A obj = new A();
        int res = obj.Add(50, 30);
        Console.WriteLine($"Result is {res}");
    }
}