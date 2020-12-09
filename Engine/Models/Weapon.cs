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
