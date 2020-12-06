using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Engine.Models;

namespace Engine.Factories
{
    internal static class ItemFactory
    {

        private static Dictionary<int, Item> _items { get; }

        static ItemFactory()
        {

            _items = new Dictionary<int, Item>();

            _items.Add(1001, new Weapon(1001, "Pointy Stick", "A sturdy stick", 1, 1, 2));

        }

        public static Item CreateItem( int typeID )
        {
            return _items.ContainsKey(typeID) ? _items[typeID].Clone() : null;
        }
    }
}
