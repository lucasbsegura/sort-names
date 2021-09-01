using System;
using System.Collections.Generic;
using System.Linq;

namespace SortNamesApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Sort.Random(Names()).ForEach(name => Console.WriteLine(name));

            Console.ReadKey();
        }

        public static List<string> Names() => new() { "Arnaldo", "Bruno", "Carlos", "Lucas", "Ronaldo", "Wilson", };
    }

    public static class Sort
    {
        public static List<string> Random(List<string> names) => names.OrderBy(x => Guid.NewGuid()).ToList();

        public static List<string> Alphabetical(List<string> names) => names.OrderBy(i => i).ToList();
    }
}

