﻿using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");
         int[] numbers={1,2,3,4,5,6,7,8,9,100,20,30,40,50,60,};
        var lambda1 = numbers.ToArray();

        var lambda2 = numbers.OrderByDescending(x=>x).ToArray();

        foreach (int item in lambda2)
        {
            Console.WriteLine(item);
        }
    }

}
 