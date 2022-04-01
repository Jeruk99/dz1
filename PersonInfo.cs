using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class PersonInfo
    {
        public string Name { get; private set; }
        public string Number { get; private set; }
        public PersonInfo(string name, string number)
        {
            Name = name;
            Number = number;
        }
    }
}
