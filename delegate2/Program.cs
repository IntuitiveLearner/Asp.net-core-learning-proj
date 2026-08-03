

using System.Data;
public delegate void MyDel(int x, int y);
class Program
{
    static void Main(string[] args)
    {
        //anonymous fn
        MyDel del =(x,y)=>{
            int res = x+y;
            Console.WriteLine($"Result is:{res}");
            int res2= x*y;
            Console.WriteLine($"Result is:{res2}");

        };
        del(20, 30);
    }
}