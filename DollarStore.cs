using System.Collections.Generic;
namespace Mall
{
    public class DollarStore : IStorable<DollarItem>
    {
        private Dictionary<string, DollarItem> _inventory { get; set; } = new Dictionary<string, DollarItem>();
        private double _price = 1.00;

        public void addItemToIventory(string name, DollarItem item)
        {
            _inventory.Add(name, item);
        }

        public DollarItem GetFromIventory(string Name)
        {
            return _inventory[Name];
        }

    }
}