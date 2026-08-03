// Program on static constructor

class A
{
    //static constructor
    static A()
    {
        Console.WriteLine("I am inside static constructor");
    }
}

// driver class 
class Program
{
    static void Main()
    {
        new A();
        new A();
        new A();        
    }
}