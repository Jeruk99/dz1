using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class Book
    {
        private Page[] pages;

        public Page this [int ind]
        {
            get { return pages[ind]; }
            set { pages[ind] = value; }
        }
        public int Count
        {
            get { return pages.Length;  }
        }
        public void Find(string name)
        {
            int i=0,k  =  0;
            while(this[k][i].Name!=name)
            {
                if (i==this[k].Count-1)
                {
                    k++;
                    i=-1;
                }
                i++;
            }
            Console.WriteLine($"Номер {name} - "+this[k][i].Number);
        }
        public Book()
        {
            pages = new Page[3];
        }
    }
}

