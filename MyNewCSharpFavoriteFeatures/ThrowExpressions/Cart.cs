using System.Collections.Generic;

namespace MyNewCSharpFavoriteFeatures.ThrowExpressions
{
    public class Cart
    {
        List<Item> Items { get; set; }

        public Cart()
        {
        }

        public void AddItem(Item item) => Items.Add(item);
    }
}
