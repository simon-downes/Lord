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

        private static Dictionary<Types, Item> _items { get; } = new Dictionary<Types, Item>();

        static ItemFactory()
        {

            _items.Add(Types.PointyStick, new Weapon(Types.PointyStick, "Pointy Stick", "A sturdy stick", 1, 1, 2));

        }

        public static Item CreateItem( Types typeID )
        {
            return _items.ContainsKey(typeID) ? _items[typeID].Clone() : null;
        }
        public static Weapon CreateWeapon(Types typeID)
        {
            return _items.ContainsKey(typeID) ? ((Weapon) _items[typeID]).Clone() : null;
        }
    }
}
