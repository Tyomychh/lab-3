using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    internal class Content
    {
        private string ccontext;
        public string Сontents
        {
            get { return ccontext; }
        }

        public Content(string context)
        {
            this.ccontext = context;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(ccontext);
        }
    }
}
