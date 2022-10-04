using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    internal class Title
    {
        private readonly string ttitle;

        public string TitleName
        {
            get { return ttitle; }
        }
        public Title(string title)
        {
            this.ttitle = title;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(ttitle);
        }
    }
}
