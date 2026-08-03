// basic event handling practice 
public delegate void DelEventHandler();

class A
{
    public void Msg1()
    {
        Console.WriteLine("Message 1");
    }
    public void Msg2()
    {
        Console.WriteLine("Message 2");
    }
    public void Msg3()
    {
        Console.WriteLine("Message 3");
    }
}
class Program
{
    static event DelEventHandler del;
    static void Main(string[] args)
    {
        A obj = new A();
        del+=obj.Msg1;
        del+=obj.Msg2;
        del+=obj.Msg3;
        del();
    }
}