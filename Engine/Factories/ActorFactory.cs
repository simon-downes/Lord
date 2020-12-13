using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal class ActorFactory
    {
        private static Dictionary<TypeID, Monster> _monsters { get; } = new Dictionary<TypeID, Monster>();

        static ActorFactory()
        {

            _monsters.Add(TypeID.Rat, new Monster(TypeID.Rat, "Rat", "A small rat", 4, 5, 5));

        }

        public static Monster CreateMonster(TypeID typeID)
        {
            return _monsters.ContainsKey(typeID) ? _monsters[typeID].Clone() : null;
        }

    }
}
