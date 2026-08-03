// See https://aka.ms/new-console-template for more information
// First program


class Program{
    static void Main()
    {
        int x, y, res;
        Console.WriteLine("Enter two number:");
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        res = x * y;
        Console.WriteLine("Product of {0} and {1} is {2}.", x, y, res);
    }
}
