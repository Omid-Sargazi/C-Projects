using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");
         int[] numbers={1,2,3,4,5,6,7,8,9,100,20,30,40,50,60,};
        var lambda1 = numbers.ToArray();

        var lambda2 = numbers.OrderByDescending(x=>x).ToArray();
        var lambda3 = numbers.Where(nameof=>nameof>30 && nameof<=80).OrderByDescending(x=>x).ToArray();
        var lambda4 = numbers.First(n=>n>8);
        var lambda5 = numbers.FirstOrDefault(x=>x>200);
        var lambda6 = numbers.Count(x=>x>0);

        List<string> Names = new List<string>();

        Names.Add("Saeed");
        Names.Add("vahid");
        Names.Add("saleh");
        Names.Add("Samiar");
        Names.Add("omid");

        var result1 = Names.ToList();

        var result2 = Names.Where(n=>n.ToLower().Contains("i")).ToList();


        foreach(string name in result2)
        {
            Console.WriteLine($"{name}");
        }



        Console.WriteLine(lambda6);

        foreach (int item in lambda3)
        {
            Console.WriteLine(item);
        }
    }

}
 