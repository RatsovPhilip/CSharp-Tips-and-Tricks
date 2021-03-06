﻿namespace AutoPropertyEnhancements
{
    using System;

    public static class Program
    {
        public static void Main()
        {
            var person = new Person();
            Console.WriteLine("{0} {1}", person.FirstName, person.LastName);

            var readOnlyPerson = new ReadOnlyPerson();
            Console.WriteLine("{0} {1}", readOnlyPerson.FirstName, readOnlyPerson.LastName);
        }
    }
}
