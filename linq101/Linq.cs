using System;
using System.Collections.Generic;
using System.Linq;
namespace Linq101
{
    public class Linq
    {
        public void GroupByExample()
        {
            List<int> numbers = new List<int>{1,2,3,4,5,6};
            var grouped = numbers.GroupBy(x => x%2==0);

            foreach (var group in grouped)
            {
                Console.WriteLine(group.Key ? "Even numbers:" : "Odd numbers:");
                foreach (var number in group)
                {
                    Console.WriteLine(number);
                }
            }
            
        }


        public  void JoinByExample()
        {
           List<string> names = new List<string> { "Alice", "Bob" };
            List<int> ids = new List<int>{1,2};
            var joined = names.Join(ids, name=>name.Length,ids=>id,(name,id)=>{name,id});
        }
    }
}