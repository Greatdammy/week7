using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace week7.academy
{
    public class Program
    {
        public static void Main()
        {
            var accounts = Account.GetAccounts();


            var sum = accounts.Select(x => x.Amount )                            
                               .Sum(x => x);
            Task.Run(() => Console.WriteLine($"Total amount: {sum}"));
            Console.WriteLine();

            
            var list = accounts.Select(x => x.Name)
                                .OrderBy(x => x)
                                .ToList();
            foreach(var names in list)
            {
                Task.Run(() => Console.WriteLine(names));
            }

            Console.ReadKey();
            Console.WriteLine();

            var days = week.GetWeeks();

            var item = days.Select(x => x.Days)
                            .OrderBy(x => x);
            Console.WriteLine("Days of the week:");
            foreach(var day in item)
            {
                Console.WriteLine(day);
            }
            Console.WriteLine();


            var mont = year.GetYears();

            var item2 = mont.Select(x => x.Months)
                            .OrderBy(x =>x);
            Console.WriteLine("Months of the year:");
            foreach( var month in item2)
            {
                Console.WriteLine(month);
            }

            Console.WriteLine();

            var items = item2.Select(x => x)
                             .Reverse().Take(2)
                             .OrderBy(x => x);
            foreach( var item1 in items)
            {
                Console.WriteLine(item1);
            }

        }

        
      
       

    }
}
