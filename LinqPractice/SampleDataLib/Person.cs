﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SampleDataLib
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ExpLevel { get; set; }
        public DateTime Birthday { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
