namespace DataStructure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        List<int> numbers = new List<int>{1,2,3};
        numbers.Add(100);
        Console.WriteLine(numbers.Count);


        Console.WriteLine("////////////////////////////");
        int[] arr = {1,2,3};
        Stack<List<int>> stack = new Stack<List<int>>();
        stack.Push(new List<int>(arr));
        stack.Push(new List<int>(arr));
        Console.WriteLine("Stack: "+stack.Count);
        Console.WriteLine("Stack: "+stack.Pop());
        }

    }
}