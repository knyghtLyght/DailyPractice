using System;
using System.Collections.Generic;
using System.Text;

namespace SampleDataLib
{
    public class SamplePersonList
    {
        public static List<Person> LoadSampleData()
        {
            List<Person> output = new List<Person>();

            output.Add(new Person 
            { 
                FirstName = "Kevin", 
                LastName = "Farrow",
                ExpLevel = 35,
                Birthday = Convert.ToDateTime("11/27/1984")
            });
            output.Add(new Person
            {
                FirstName = "Kest",
                LastName = "Farstrider",
                ExpLevel = 8,
                Birthday = Convert.ToDateTime("01/08/2020")
            });
            output.Add(new Person
            {
                FirstName = "Smash",
                LastName = "Raptor",
                ExpLevel = 26,
                Birthday = Convert.ToDateTime("05/12/1992")
            });
            output.Add(new Person
            {
                FirstName = "Cirilla",
                LastName = "Goth",
                ExpLevel = 2,
                Birthday = Convert.ToDateTime("08/22/1852")
            });
            output.Add(new Person
            {
                FirstName = "Aust",
                LastName = "Goodnem",
                ExpLevel = 10,
                Birthday = Convert.ToDateTime("12/15/2000")
            });
            output.Add(new Person
            {
                FirstName = "Maki",
                LastName = "Kusakabe",
                ExpLevel = 10,
                Birthday = Convert.ToDateTime("8/18/1999")
            });

            return output;
        }
    }
}
