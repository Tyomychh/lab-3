using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    internal class Author
    {
        private readonly string aauthor;

        public Author(string author)
        {
            this.aauthor = author;
        }


        public string Writer
        {
            get { return aauthor; }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(aauthor);
        }
    }
}
