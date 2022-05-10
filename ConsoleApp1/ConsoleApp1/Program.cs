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
    
    static void Main(string[] args)
    {
        var selection = Console.ReadLine();
        //Action<string> func ;
        Func<string,bool> func ;
        if(selection =="1")
         func = message =>
         {
             Console.WriteLine(message + " " + DateTime.Now);
             return true;
         };
        else
        {
            func = message =>
            {
                {
                    Console.WriteLine(message);
                    return true;
                }
            };
        }
        ExecuteWrite(func);
    }

    private static bool ExecuteWrite(Func<string, bool> func)
    {
       return func("Hello World");
    }
}