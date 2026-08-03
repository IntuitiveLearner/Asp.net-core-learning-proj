// Constructor - instance(parameterized, non-parameterized), static, copy

class A{
    int res;
    public A(int a, int b)
    {
        res = a*b;
    }
    public void Display()
    {
        Console.WriteLine("Result is {0}", res);
    }
}

class Program
{
    static void Main()
    {
        A obj = new A(20,20);
        obj.Display();
    }
}