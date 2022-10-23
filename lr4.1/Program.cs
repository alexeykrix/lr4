using System;
using System.Diagnostics;


class Test
{
    public void LogToDebug(params object[] value)
    { 
        foreach (var item in value)
        {
            Debug.WriteLine(item.GetType());
            Debug.WriteLine(item);
        }
        
    }
}

class Program
{
    static void Main(string[] args)
    {
        Test test = new Test();
        
        test.LogToDebug(434, "ddsfs");
    }
}