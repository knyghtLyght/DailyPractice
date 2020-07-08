using SampleDataLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = SamplePersonList.LoadSampleData();

            people = people.OrderBy(x => x.LastName).ThenBy(x => x.ExpLevel).ToList();

            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} {person.Birthday.ToShortDateString()} Exp Level: {person.ExpLevel}");
            }
        }
    }
}
