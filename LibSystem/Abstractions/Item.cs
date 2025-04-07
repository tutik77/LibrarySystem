using System;

namespace LibSystem
{
    abstract public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public event Action<Item> ItemCheckedOut;
        public event Action<Item> ItemReturned;
        public event Action<Item> ItemReserved;

        protected void OnItemCheckedOut() => ItemCheckedOut?.Invoke(this);
        protected void OnItemReturned() => ItemReturned?.Invoke(this);
        protected void OnItemReserved() => ItemReserved?.Invoke(this);

        protected Item(int id, string name, int year)
        {
            Id = id;
            Name = name;
            Year = year;
        }

        public abstract void DisplayInfo();
    }
}
