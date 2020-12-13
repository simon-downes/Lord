using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal class MonsterFactory
    {
        private static Dictionary<Types, Monster> _monsters { get; } = new Dictionary<Types, Monster>();

        static MonsterFactory()
        {

            _monsters.Add(Types.Rat, new Monster(Types.Rat, "Rat", "A small rat", 4, 5, 5));

        }

        public static Monster CreateItem(Types typeID)
        {
            return _monsters.ContainsKey(typeID) ? _monsters[typeID].Clone() : null;
        }

    }
}
