using System.Collections.Generic;
using System.Linq;

namespace LibSystem
{
    public class Library
    {
        public List<Item> Items {  get; private set; }

        public Library()
        {
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }

        public List<Item> SearchByTitle(string keyword)
        {
            var selectedPeople = Items.Where(b => b.Name.Contains(keyword)).ToList();
            return selectedPeople;
        }

        public List<Item> GetItemsByYear(int year)
        {
            var selectedPeople = Items.Where(b => b.Year == year).ToList();
            return selectedPeople;
        }

        public Dictionary<int, List<Item>> GroupItemsByYear()
        {
            var groupsDict = Items.GroupBy(b =>  b.Year)
                .ToDictionary(group => group.Key, group => group.ToList());

            return groupsDict;
        }
    }
}
