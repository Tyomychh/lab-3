using System;

namespace Invoice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1000, "Tyomich", "Pizza");

            Console.WriteLine("Якщо хочете знати сумму з ПДВ: напишiть 1");
            Console.WriteLine("Якщо хочете знати сумму без ПДВ: Напишiть 2");

            string article = Console.ReadLine();
            invoice.Article = article;

            Console.WriteLine(invoice.tax());
        }
    }
}
