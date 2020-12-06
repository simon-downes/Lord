using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    class Weapon : Item
    {

        public int MinDamage { get; }
        public int MaxDamage { get; }

        public Weapon(int typeId, string name, string description, int price, int minDamage, int maxDamage) : base(typeId, name, description, price)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

        public new Weapon Clone()
        {
            return new Weapon(TypeId, Name, Description, Price, MinDamage, MaxDamage);
        }

    }
}
