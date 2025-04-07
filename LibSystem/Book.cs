using System;
using System.Net;
using System.Threading;
using LibSystem.Abstractions;

namespace LibSystem
{
    public class Book: Item, ICheckable, IReservable
    {
        public Author Author { get; set; }
        public int ISBN { get; set; }
        public bool IsCheckedOut { get; private set; }
        public bool IsReserved { get; private set; }

        public Book(int id, string name, int year, Author author, int isbn) : base(id, name, year)
        {
            Author = author;
            ISBN = isbn;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Book: {Name}\nISBN: {ISBN}\nAuthor: {Author}");
        }

        public void CheckOut()
        {
            if (!IsCheckedOut)
            {
                IsCheckedOut = true;
                OnItemCheckedOut();
            }
        }

        public void Return()
        {
            if (IsCheckedOut)
            {
                IsCheckedOut = false;
                OnItemReturned();
            }
        }

        public void Reserve()
        {
            if (!IsReserved)
            {
                IsReserved = true;
                OnItemReserved();
            }
        }

        public void CancelReservation()
        {
            if (IsReserved)
            {
                IsReserved = false;
            }
        }
    }
}