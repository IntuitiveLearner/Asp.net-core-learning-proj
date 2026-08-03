
public delegate void MyDel(int x, int y);
class A
{
    public void Add(int x, int y)
    {
        int res = x + y;
        Console.WriteLine($"Sum = {res}");
    }
    
    public void Sub(int x, int y)
    {
        int res = x - y;
        Console.WriteLine($"Difference = {res}");
    }
    
    public void Mul(int x, int y)
    {
        int res = x * y;
        Console.WriteLine($"Product = {res}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        A obj = new A();
        MyDel del= obj.Add;
        del += obj.Sub;         //Delegate multicasting 
        del += obj.Mul;
        del(30, 20);
    }
}