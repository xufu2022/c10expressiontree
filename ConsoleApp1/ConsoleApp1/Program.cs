// See https://aka.ms/new-console-template for more information

//void DelegateMethod(string message) => Console.WriteLine((message));

//Del handler=DelegateMethod;

//handler("Show message");

//public delegate void Del(string message);

//create method for a delegate
// Delegates allow you to time shift

// feels like interface
// is inversion of control

namespace  ConsoleApp1;

internal class Program
{
    public delegate void WriteMessageFunction(string message);

    public static void WriteMessage(string message)
    {
        Console.WriteLine(message);
    }    
    public static void WriteTimelyMessage(string message)
    {
        Console.WriteLine(message + " " + DateTime.Now);
    }

    static void Main(string[] args)
    {
        var selection = Console.ReadLine();
        WriteMessageFunction func ;
        if(selection =="1")
         func = WriteTimelyMessage;
        else
        {
            func = WriteMessage;
        }
        func("Hello World");
    }
}