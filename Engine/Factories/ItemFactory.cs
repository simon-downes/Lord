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

            _items.Add((int) Types.PointyStick, new Weapon((int) Types.PointyStick, "Pointy Stick", "A sturdy stick", 1, 1, 2));

        }

        public static Item CreateItem( Types typeID )
        {
            return _items.ContainsKey((int) typeID) ? _items[(int) typeID].Clone() : null;
        }
        public static Weapon CreateWeapon(Types typeID)
        {
            return _items.ContainsKey((int) typeID) ? ((Weapon) _items[(int) typeID]).Clone() : null;
        }
    }
}
