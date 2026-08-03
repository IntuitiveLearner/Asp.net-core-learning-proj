//There are different kind of exceptions, we will just try to implement the basics of exception handling

class Program
{
    static void Main(string[] args)
    {
        int x = 10, y=0, res;
        try
        {
            res = x/y; // divide by zero exception
            Console.WriteLine($"Result is: {res}");
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally always runs!");
        }
    }
}