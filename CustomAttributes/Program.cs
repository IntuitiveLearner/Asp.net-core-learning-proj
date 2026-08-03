[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
class CsitAttribute : Attribute
{
    string msg{get; set;}
    public CsitAttribute(string msg)
    {
        this.msg=msg;
    }
}
[Csit("This is a class")]
class A
{
    [Csit("This is a method")]
    public void Message()
    {
        Console.WriteLine("This is a test.");
    }
}
class Program
{
    static void Main()
    {
        A obj = new A();
        obj.Message();       
    }
}