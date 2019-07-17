using System.Collections.Generic;
namespace Mall
{
    public class FoodStore : IStorable<FoodItem>
    {
        private Dictionary<string, FoodItem> _inventory = new Dictionary<string, FoodItem>();
        public void addItemToIventory(string name, FoodItem item)
        {
            _inventory.Add(name, item);
        }
    }
}