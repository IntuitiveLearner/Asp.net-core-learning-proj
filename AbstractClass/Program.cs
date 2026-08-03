

// Abstract class

abstract class A
{
    public abstract void Add(int x, int y);
    public abstract void Display();

}

// to use an abstract class we cannot make its obj, we need to use inheritence to make use of it.

class B : A
{
    int res;
    public override void Add(int x, int y)
    {
        res = x + y;
    }
    // Here polymorphism overriding is implemented
    public override void Display()
    {
        Console.WriteLine($"Sum = {res}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        B obj = new B();
        obj.Add(44, 56);
        obj.Display();
    }
}
