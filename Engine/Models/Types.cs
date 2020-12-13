using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{

    public enum TypeGroup
    {
        Location = 1000,
        NPC      = 2000,
        Monster  = 3000,
        Item     = 4000,
        Weapon   = 5000,
        Armour   = 6000,
    }

    public enum TypeID
    {
        // worlds
        Immensea = 1,
        
        // uniques
        Player = 100,

        // locations 1xxx
        Honeywood = 1000,
        Meadow    = 1001,
        Forest    = 1002,
        Wildlands = 1003,
        Mountains = 1004,


        // npcs 2xxx

        // monsters 3xxx
        Rat = 3000,


        // items 4xxx

        // weapons 5xxx
        PointyStick = 4000,

        // armour 6xxx

    }

    public static class Type
    {

        private static bool Between(int num, int lower, int upper)
        {
            return lower <= num && num <= upper;
        }

        public static bool IsLocation(TypeID typeID)
        {
            return Between((int) typeID, 1000, 1999);
        }

        public static bool IsNPC(TypeID typeID)
        {
            return Between((int) typeID, 2000, 2999);
        }

        public static bool IsMonster(TypeID typeID)
        {
            return Between((int) typeID, 3000, 3999);
        }

        public static bool IsItem(TypeID typeID)
        {
            return Between((int) typeID, 4000, 4999);
        }

        public static bool IsWeapon(TypeID typeID)
        {
            return Between((int) typeID, 5000, 5999);
        }

        public static bool IsArmour(TypeID typeID)
        {
            return Between((int) typeID, 6000, 6999);
        }

    }

}
