using System;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonInfo st1 = new PersonInfo("Artem", "89378483848");
            PersonInfo st2 = new PersonInfo("Anna", "89685929485");
            PersonInfo st3 = new PersonInfo("Boris", "89275838584");
            PersonInfo st4 = new PersonInfo("Bogdan", "89285838584");
            PersonInfo st5 = new PersonInfo("Darya", "89375845748");
            PersonInfo st6 = new PersonInfo("Dima", "89275768574");
            Page p1 = new Page('A');
            p1[0] = st1;
            p1[1] = st2;
            Page p2 = new Page('B');
            p2[0] = st3;
            p2[1] = st4;
            Page p3 = new Page('C');
            p3[0] = st5;
            p3[1] = st6;
            Book b1 = new Book();
            b1[0] = p1;
            b1[1] = p2;
            b1[2] = p3;
            string search = "";
            {
                search = Console.ReadLine();
                try
                { b1.Find(search);  }
                catch(IndexOutOfRangeException)
                { Console.WriteLine("Человека с введённым именем не существует"); }
            }
        
            
        }
    }
}
