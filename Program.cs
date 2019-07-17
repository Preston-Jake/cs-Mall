using System;

namespace Mall
{
    class Program
    {
        static void Main(string[] args)
        {
            var Dollarama = new DollarStore();

            var Cinnabon = new FoodStore();

            var MultiColorPen = new DollarItem()
            {
                Name = "Multi Colored Pen"
            };

            Dollarama.addItemToIventory("mcp", MultiColorPen);

            var CaramelPecanbon = new FoodItem()
            {
                Name = "Carmamel Pecanbon",
                Price = 6,
                Calories = 880
            };

            Cinnabon.addItemToIventory("cp", CaramelPecanbon);

            Dollarama.GetFromIventory("mcp");
        }
    }
}
