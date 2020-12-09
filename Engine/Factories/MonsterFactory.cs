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
        private static Dictionary<int, Monster> _monsters { get; }

        static MonsterFactory()
        {

            _monsters = new Dictionary<int, Monster>();

            _monsters.Add((int)Types.Rat, new Monster((int) Types.Rat, "Rat", "A small rat", 4, 5, 5));

        }

        public static Monster CreateItem(Types typeID)
        {
            return _monsters.ContainsKey((int) typeID) ? _monsters[(int) typeID].Clone() : null;
        }

    }
}
