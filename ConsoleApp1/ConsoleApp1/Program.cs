// See https://aka.ms/new-console-template for more information

//void DelegateMethod(string message) => Console.WriteLine((message));

//Del handler=DelegateMethod;

//handler("Show message");

//public delegate void Del(string message);

//create method for a delegate
// Delegates allow you to time shift

// feels like interface
// is inversion of control

using System.Linq.Expressions;

namespace  ConsoleApp1;

internal class Program
{


    static void Main(string[] args)
    {
        var xExpression = Expression.Parameter(typeof(int), "x");
        var constExpression = Expression.Constant(12);
        var const4Expression = Expression.Constant(4);
        var greaterThan = Expression.GreaterThan(xExpression, constExpression);
        var lessThan = Expression.LessThan(xExpression, const4Expression);

        var or = Expression.Or(greaterThan, lessThan);

        var expr = Expression.Lambda<Func<int, bool>>(or,false,
            new List<ParameterExpression> { xExpression });
        var func=expr.Compile();

        Console.WriteLine(func(2));

    }

}