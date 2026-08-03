

using System;

class Test
{
    [Obsolete("Don't use Message().")] //Predefined Attribute
    public void Message()
    {
        Console.WriteLine("This is obsolete attribute test!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Test obj = new Test();
        obj.Message();
    }
}