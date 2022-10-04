using System;

namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишiть назву книги");
            string title = Console.ReadLine();

            Console.WriteLine("Напишiть iм'я автора книги");
            string author = Console.ReadLine();

            Console.WriteLine("Напишiть про що ця книга книги");
            string content = Console.ReadLine();

            Book book = new Book(new Title(title), new Author(author), new Content(content));

            Console.Clear();
            book.Title.Show();
            book.Author.Show();
            book.Content.Show();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
