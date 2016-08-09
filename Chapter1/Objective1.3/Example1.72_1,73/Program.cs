using System;
using System.Collections.Generic;

namespace Example1._72
{
    class Program
    {
        static void Main(string[] args)
        {

            var people = new List<Person>
            {
                new Person() { FirstName = "John", LastName = "Doe"},
                new Person() { FirstName = "Jane", LastName = "Doe"},
            };
            foreach (var p in people)
            {
                p.LastName = "Changed"; // This is allowed
                // p = new Person(); // This gives a compile error
            }

            // Compiler generated code
            var e = people.GetEnumerator();
            try
            {
                Person v;
                while (e.MoveNext())
                {
                    v = e.Current;
                    Console.WriteLine(v.LastName);
                }
            }
            finally
            {
                var d = e as System.IDisposable;
                if (d != null) d.Dispose();
            }
            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        internal class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
