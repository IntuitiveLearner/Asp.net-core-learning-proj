
using System;

class Student
{
    private int sid; //field
    private string name;
    
    public int Sid  // property
    {
        get{return sid;}
        set{sid = value;}
    }
    public string Name
    {
        get{return name;}
        set{name = value;}
    }
}



class Program
{
    static void Main()
    {
        Student st = new Student();
        st.Sid=10;
        st.Name = "Sachin Raut";
        Console.WriteLine("Sid={0} Name={1}",st.Sid,st.Name);
    }
}