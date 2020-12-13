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

        private static Dictionary<TypeID, Item> _items { get; } = new Dictionary<TypeID, Item>();

        private static Dictionary<TypeID, Weapon> _weapons { get; } = new Dictionary<TypeID, Weapon>();

        static ItemFactory()
        {

            _weapons.Add(TypeID.PointyStick, new Weapon(TypeID.PointyStick, "Pointy Stick", "A sturdy stick", 1, 1, 2));
        }

        public static Item CreateItem( TypeID typeID )
        {
            return _items.ContainsKey(typeID) ? _items[typeID].Clone() : null;
        }
        public static Weapon CreateWeapon(TypeID typeID)
        {
            return _weapons.ContainsKey(typeID) ? _weapons[typeID].Clone() : null;
        }
    }
}

