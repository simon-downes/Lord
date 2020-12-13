using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Weapon : Item
    {

        public int MinDamage { get; private set; }
        public int MaxDamage { get; private set; }

        public Weapon(Types typeID, string name, string description, int price, int minDamage, int maxDamage) : base(typeID, name, description, price)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

        public new Weapon Clone()
        {
            return new Weapon(TypeID, Name, Description, Price, MinDamage, MaxDamage);
        }

    }
}
