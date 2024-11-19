using System.Linq.Expressions;
using System;
namespace CompileExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Expression<Func<int, bool>> isEvenExpression = number =>number%2==0;
            Func<int,bool> isEventFunc = isEvenExpression.Compile();
            Console.WriteLine(isEventFunc(4));
        }
    }
}