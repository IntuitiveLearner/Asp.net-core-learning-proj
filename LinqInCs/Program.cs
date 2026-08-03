using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        list.Add("Btm");
        list.Add("Ktm");
        list.Add("Btm");
        list.Add("Ktm");
        
        //select data whose address is birtamode...
        //linq query

        var res= from x in list
                 where x =="Btm"
                 select x;

        foreach(var item in res)
            Console.WriteLine(item);

    }
}