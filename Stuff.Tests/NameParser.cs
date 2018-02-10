﻿using System;

namespace Stuff.Tests
{
    public class NameParser
    {
        internal NameParser Parse(string name)
        {
            var nameParts = name.Split(' ');
            var result = new Name();

            switch (nameParts.Length)
            {
                case 1:
                    result = new Name
                    {
                        FirstName = name
                    };
                    break;

                case 2:
                    result = new Name
                    {
                        FirstName = nameParts[0],
                        LastName = nameParts[1]
                    };
                    break;

                case 3:
                    result = new Name
                    {
                        FirstName = nameParts[0],
                        MiddleName = nameParts[1],
                        LastName = nameParts[2]
                    };
                    break;
            }
            return result;
        }
    }

    public class Name
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }
}