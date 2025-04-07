using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author("Атанасян");
            Book book1 = new Book(1, "Геометрия", 2025, author, 228);
            Magazine magazine = new Magazine(2, "PLAYBOY", 2025, 229);
            Book book2 = new Book(3, "Мастер и Маргарита", 666, author, 12948);

            Library library = new Library();

            ConsoleNotifier notifier = new ConsoleNotifier();

            library.AddItem(book1);
            library.AddItem(magazine);
            library.AddItem(book2);

            Console.WriteLine("Ща будет список всей библиотеки, должно быть 2 книжки");
            foreach (var item in library.Items)
            {
                Console.WriteLine($"{item.Id} {item.Name}");
            }
            Console.WriteLine();

            Console.WriteLine("Ща будет фильтр по 2025 году");
            foreach (var item in library.GetItemsByYear(2025))
            {
                Console.WriteLine($"{item.Name} {item.Year} года");
            }
            Console.WriteLine();



            book1.CheckOut();
            book1.Return();

            book1.ItemCheckedOut += notifier.NotifyAboutCheckOut;
            book2.ItemCheckedOut += notifier.NotifyAboutCheckOut;
            magazine.ItemReturned += notifier.NotifyAboutReturn;

            book1.CheckOut();
            book1.Return();

            magazine.CheckOut();
            magazine.Return();
        }
    }
}
