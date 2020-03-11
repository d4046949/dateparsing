using System;
using System.Linq;

namespace DateOrdering
{
    class Program
    {
        static void Main(string[] args) 
        {
            var entries = new FileParser().ReadFile();

            Console.WriteLine("List in order");

            foreach (var e in entries.OrderBy(x => x.FinishDate).ToList())
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("These are finishing this year");

            foreach(var e in entries.Where(x => x.FinishDate.Year == DateTime.Now.Year).ToList())
            {
                Console.WriteLine(e.ToString());
            }

            Console.ReadLine();
        }
    }
}
