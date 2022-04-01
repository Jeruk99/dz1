using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class Page
    {
        private char letter;
        private PersonInfo[] strings;

        public char Letter
        {
            get { return letter; }
            set { letter = value; }
        }
        public PersonInfo this[int ind]
        {
            get { return strings[ind]; }
            set { strings[ind] = value;  }
        }
        public int Count
        {
            get { return strings.Length; }
        }
        public Page (char letter)
        {
            Letter = letter;
            strings = new PersonInfo[2];
        }

    }
}
